using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TestTap.Shared.Data;
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

namespace TestTap.Shared.UserControls
{
    public sealed partial class TestUserControl : UserControl

    {
        public TestModel Item => DataContext as TestModel;
        public TestUserControl()
        {
            this.InitializeComponent();
            this.AddComandUx.Click += AddComandUx_Click;
            this.DeleteCommandUx.Click += DeleteCommandUx_Click;
            //this.DataContextChanged += TestUserControl_DataContextChanged;
            //DataContextChanged += (s, e) => Bindings.Update();
        }

        private void TestUserControl_DataContextChanged(FrameworkElement sender, DataContextChangedEventArgs args)
        {
            var a = 1;
        }

        private void DeleteCommandUx_Click(object sender, RoutedEventArgs e)
        {
            TestModel s = (TestModel)this.DataContext as TestModel;
            s.EvEditMode = EditModeEnum.Delete;
        }

        private void AddComandUx_Click(object sender, RoutedEventArgs e)
        {
            TestModel s = (TestModel)this.DataContext as TestModel;
            s.EvEditMode = EditModeEnum.Add;
        }
    }
}
