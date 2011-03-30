using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Phone.Controls;

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
    }
}