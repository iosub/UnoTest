using TestTap.Shared.ViewModel;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409
namespace TestTap
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
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

        /// <summary>
        /// Initializes a new instance of the <see cref="MainPage"/> class.
        /// </summary>
        public MainPage()
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
