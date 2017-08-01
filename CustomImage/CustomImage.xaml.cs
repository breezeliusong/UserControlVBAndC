using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace CustomImage
{
    public sealed partial class CustomImage : UserControl
    {
        public CustomImage()
        {
            this.InitializeComponent();
            this.DataContext = this;
        }



        public string MySource
        {
            get { return (string)GetValue(MySourceProperty); }
            set { SetValue(MySourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MySource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MySourceProperty =
            DependencyProperty.Register("MySource", typeof(string), typeof(CustomImage), new PropertyMetadata(null));



        public double MyAngle
        {
            get { return (double)GetValue(MyAngleProperty); }
            set { SetValue(MyAngleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyAngle.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyAngleProperty =
            DependencyProperty.Register("MyAngle", typeof(double), typeof(CustomImage), new PropertyMetadata(null));


    }
}
