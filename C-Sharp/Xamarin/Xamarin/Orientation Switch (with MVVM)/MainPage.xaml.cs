using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AdaptiveLayoutTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (width > height)
            {
                RootGrid.RowDefinitions[0].Height = new GridLength(1, GridUnitType.Star);
                RootGrid.Children[0].IsVisible = true;
                RootGrid.RowDefinitions[1].Height = new GridLength(0, GridUnitType.Star);
                RootGrid.Children[1].IsVisible = false;
            }
            else
            {
                RootGrid.RowDefinitions[0].Height = new GridLength(0, GridUnitType.Star);
                RootGrid.Children[0].IsVisible = false;
                RootGrid.RowDefinitions[1].Height = new GridLength(1, GridUnitType.Star);
                RootGrid.Children[1].IsVisible = true;
            }
        }
    }
}
