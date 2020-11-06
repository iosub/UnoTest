using System.ComponentModel;
using TestTap.Shared.Data;
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
            //this.ListUx.Tapped += ListUx_Tapped;
            this.ListT2Ux.IsItemClickEnabled = true;
            this.ListT2Ux.ItemClick += ListT2Ux_ItemClick;
        }

        internal void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var t = (ListView)sender as ListView;

            System.Diagnostics.Debug.WriteLine("TAB EN CURSO " + t.Name);
            foreach (var item in e.AddedItems)
            {
                TestModel Nuevo = (TestModel)item as TestModel;
                System.Diagnostics.Debug.WriteLine("TAB EN CURSO NUEVO " + t.Name + " " );
                if (Nuevo != null)
                {
                    Nuevo.PropertyChanged -= Item_PropertyChanged;
                    Nuevo.EvEditMode = EditModeEnum.None;
                    Nuevo.PropertyChanged += Item_PropertyChanged;
                    break;
                }

            }
            foreach (var item in e.RemovedItems)
            {
                TestModel Anterior = (TestModel)item as TestModel;

                System.Diagnostics.Debug.WriteLine("TAB EN CURSO ANTERIOR " + t.Name + " " );
                if (Anterior != null)
                {
                    Anterior.PropertyChanged -= Item_PropertyChanged;
                    Anterior.EvEditMode = EditModeEnum.None;
                }

            }
        }

        private void Item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            TestModel task = (TestModel)sender as TestModel;
            task.PropertyChanged -= Item_PropertyChanged;
            if (e.PropertyName== "EvEditMode")
            {
                switch (task.EvEditMode)
                {
                    case EditModeEnum.Add:
                        ViewModel.TestValue = ViewModel.TestValue + 1;
                        break;
                    case EditModeEnum.Delete:
                         ViewModel.TestValue = ViewModel.TestValue -1;
                        break;

                }

            }
            task.PropertyChanged += Item_PropertyChanged;

        }

        private void ListT2Ux_ItemClick(object sender, ItemClickEventArgs e)
        {
            var a = 1;
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
