using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TestTap.Shared.ViewModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace TestTap.Shared.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TestViewPivot : Page
    {
        /// <summary>
        /// Gets the ViewModel.
        /// </summary>
        public TestViewModel ViewModel
        {
            get
            {
                return DataContext as TestViewModel;
            }
        }
        public TestViewPivot()
        {
            this.InitializeComponent();
            this.DataContext = new TestViewModel();
            this.ListUx.Tapped += ListUx_Tapped;
        }
        /// <summary>
        /// The ListUx_Tapped.
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>.</param>
        /// <param name="e">The e<see cref="TappedRoutedEventArgs"/>.</param>
        private void ListUx_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var a = 1;
        }
    }
}
