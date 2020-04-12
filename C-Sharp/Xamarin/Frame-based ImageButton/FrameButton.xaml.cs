using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GradProjMobile.Views.UserControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FrameButton : Frame
    {
        #region Constructors
        public FrameButton()
        {
            InitializeComponent();
            BindingContext = this;
            //base.BackgroundColor = Color.Transparent;
        }
        #endregion
        #region Events
        public event EventHandler<EventArgs> Tapped;
        #endregion
        #region Private props
        #endregion
        #region Public props
        public static readonly BindableProperty TextProperty =
                BindableProperty.Create("Text", typeof(string), 
                    typeof(FrameButton), string.Empty);

        public static readonly BindableProperty TextColorProperty =
                BindableProperty.Create("TextColor", typeof(Color),
                    typeof(FrameButton), Color.Black);

        public static readonly BindableProperty FontSizeProperty =
                BindableProperty.Create("FontSize", typeof(double),
                    typeof(FrameButton), 14.0);

        public static readonly BindableProperty FontFamilyProperty =
                BindableProperty.Create("FontFamily", typeof(string),
                    typeof(FrameButton), string.Empty);

        public static readonly BindableProperty FontAttributesProperty =
                BindableProperty.Create("FontAttributes", typeof(FontAttributes),
                    typeof(FrameButton), FontAttributes.None);

        public static readonly BindableProperty CommandProperty =
                BindableProperty.Create("Command", typeof(ICommand),
                    typeof(FrameButton), null);

        public static readonly BindableProperty CommandParameterProperty =
                BindableProperty.Create("CommandParameter", typeof(object),
                    typeof(FrameButton), null);

        public static readonly BindableProperty ImageSourceProperty =
                BindableProperty.Create("ImageSource", typeof(ImageSource),
                    typeof(FrameButton), null);
        /* hidden props
        public static readonly BindableProperty BackgroundColorProperty =
                BindableProperty.Create("BackgroundColor", typeof(Color),
                    typeof(FrameButton), Color.White);

        public new static readonly BindableProperty BorderColorProperty =
                BindableProperty.Create("BorderColor", typeof(Color),
                    typeof(FrameButton), Color.Transparent);

        public new static readonly BindableProperty CornerRadiusProperty =
                BindableProperty.Create("CornerRadius", typeof(float),
                    typeof(FrameButton), (float)0.0);
        */
        //wrong bindable props?
        //public static readonly BindableProperty TextProperty =
        //        BindableProperty.Create("Text", typeof(string),
        //            typeof(Label), string.Empty);
        //public static readonly BindableProperty TextColorProperty =
        //        BindableProperty.Create("TextColor", typeof(Color),
        //            typeof(Label), Color.Black);
        //public static readonly BindableProperty FontSizeProperty =
        //        BindableProperty.Create("FontSize", typeof(double),
        //            typeof(Label), 14);
        //public static readonly BindableProperty FontFamilyProperty =
        //        BindableProperty.Create("FontFamily", typeof(string),
        //            typeof(Label), string.Empty);
        //public static readonly BindableProperty FontAttributesProperty =
        //        BindableProperty.Create("FontAttributes", typeof(FontAttributes),
        //            typeof(Label), FontAttributes.None);
        //public static readonly BindableProperty CommandProperty =
        //        BindableProperty.Create("Command", typeof(ICommand),
        //            typeof(TapGestureRecognizer), null);
        //public static readonly BindableProperty CommandParameterProperty =
        //        BindableProperty.Create("CommandParameter", typeof(object),
        //            typeof(TapGestureRecognizer), null);
        //public static readonly BindableProperty ImageSourceProperty =
        //        BindableProperty.Create("ImageSource", typeof(ImageSource),
        //            typeof(Image), null);
        //public new static readonly BindableProperty BackgroundColorProperty =
        //        BindableProperty.Create("BackgroundColor", typeof(Color),
        //            typeof(Frame), Color.White);
        //public static readonly BindableProperty BorderColorProperty =
        //        BindableProperty.Create("BorderColor", typeof(Color),
        //            typeof(Frame), Color.Transparent);
        //public static readonly BindableProperty CornerRadiusProperty =
        //        BindableProperty.Create("CornerRadius", typeof(float),
        //            typeof(Frame), 0);
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }
        public double FontSize
        {
            get { return (double)GetValue(FontSizeProperty); }
            set { SetValue(FontSizeProperty, value); }
        }
        public string FontFamily
        {
            get { return (string)GetValue(FontFamilyProperty); }
            set { SetValue(FontFamilyProperty, value); }
        }
        public FontAttributes FontAttributes
        {
            get { return (FontAttributes)GetValue(FontAttributesProperty); }
            set { SetValue(FontAttributesProperty, value); }
        }
        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }
        public object CommandParameter
        {
            get { return (object)GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }
        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }
        //hidden props
        //public new Color BackgroundColor
        //{
        //    get { return (Color)GetValue(BackgroundColorProperty); }
        //    set { SetValue(BackgroundColorProperty, value); }
        //}
        //public new Color BorderColor
        //{
        //    get { return (Color)GetValue(BorderColorProperty); }
        //    set { SetValue(BorderColorProperty, value); }
        //}
        //public new float CornerRadius
        //{
        //    get { return (float)GetValue(CornerRadiusProperty); }
        //    set { SetValue(CornerRadiusProperty, value); }
        //}
        #endregion
        #region Public methods
        #endregion
        #region Protected methods
        protected void OnButtonTapped(object sender, EventArgs args)
        {
            object resolvedParameter;

            if (CommandParameter != null)
            {
                resolvedParameter = CommandParameter;
            }
            else
            {
                resolvedParameter = args;
            }

            if (Command?.CanExecute(resolvedParameter) ?? true)
            {
                Tapped?.Invoke(this, args);
                Command?.Execute(resolvedParameter);
            }
        }
        #endregion
        #region Private methods
        #endregion

    }
}