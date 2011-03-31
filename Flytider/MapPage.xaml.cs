using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Flytider
{
    public partial class MapPage : PhoneApplicationPage
    {
        public MapPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            Kart.SetView(new GeoCoordinate(60.994423, 9.140625), 6);

            LastFlyplasser();
        }

        private void LastFlyplasser()
        {
            var service = new FlyplassService();
            var flyplasser = service.HentFlyplasser();

            foreach (var flyplass in flyplasser)
            {
                var image = new Image();
                image.Width = 50;
                image.Height = 50;
                var bitmapImage = new BitmapImage();
                bitmapImage.UriSource = new Uri("airplane.png", UriKind.Relative);
                image.Source = bitmapImage;
                image.CacheMode = new BitmapCache();

                FlyplassLayer.AddChild(image, new GeoCoordinate(flyplass.Lengdegrad, flyplass.Breddegrad), new Point(-25, -25));
            }
        }
    }
}