using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;

namespace Flytider
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            Loaded += MainPage_Loaded;
            Flyplasser.SelectionChanged += FlyplassBleValgt;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            var service = new FlyplassService();
            Flyplasser.ItemsSource = service.HentFlyplasser();
        }

        private void FlyplassBleValgt(object sender, SelectionChangedEventArgs e)
        {
            var flyplass = (Flyplass) Flyplasser.SelectedItem;
            
            var flygningerService = new FlygningService();
            flygningerService.HentFlygninger(flyplass, VisFlygninger);
        }

        private void VisFlygninger(List<Flygning> flygninger)
        {
            Ankomster.ItemsSource = flygninger.Where(f => f.AnnkomstAvgang == "A");
            Avganger.ItemsSource = flygninger.Where(f => f.AnnkomstAvgang == "D");
        }

        private void ApplicationBarIconButton_Click(object sender, System.EventArgs e)
        {
            var nummerTask = new PhoneNumberChooserTask();
            nummerTask.Completed += nummerTask_Completed;
            nummerTask.Show();
        }

        private void nummerTask_Completed(object sender, PhoneNumberResult e)
        {
            if (e.TaskResult != TaskResult.OK) return;
            
            var sms = new SmsComposeTask();
            sms.To = e.PhoneNumber;

            var flyplass = (Flyplass) Flyplasser.SelectedItem;
            if (flyPivot.SelectedIndex == 0)
            {
                var avgang = (Flygning)Avganger.SelectedItem;
                sms.Body = string.Format("Jeg flyr med {0} fra {1} og lander på {2} klokken {3:HH:mm}",
                                         avgang.Nummer, flyplass.Kode, avgang.Flyplass, avgang.Tidspunkt);
                sms.Show();
            }
            else if (flyPivot.SelectedIndex == 1)
            {
                var ankomst = (Flygning)Ankomster.SelectedItem;
                sms.Body = string.Format("Jeg lander med {0} fra {1} til {2} klokken {3:HH:mm}",
                                         ankomst.Nummer, ankomst.Flyplass, flyplass.Kode, ankomst.Tidspunkt);
                sms.Show();
            }
        }
    }
}