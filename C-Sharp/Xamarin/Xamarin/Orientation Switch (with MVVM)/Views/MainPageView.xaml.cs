using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AdaptiveLayoutTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPageView : ContentPage
    {
        private readonly View _portraitContent;
        private readonly View _landscapeContent;
        public MainPageView()
        {
            InitializeComponent();
            this._portraitContent = new AdaptiveLayoutTest.Views.Portrait.MainViewPortrait();
            this._landscapeContent = new AdaptiveLayoutTest.Views.Landscape.MainViewLandscape();
            this.BindingContext = new ViewModels.MainViewModel();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            if (width > height)
            {
                this.Content = _landscapeContent;
            }
            else
            {
                this.Content = _portraitContent;
            }
        }
    }
}