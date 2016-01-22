using EnigmaticEvents.ViewModels;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EnigmaticEvents
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TeamList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            (DataContext as EventViewModel).SelectedItems = TeamList.SelectedItems.ToList() ;
        }

        private void MultiSelect(object sender, RoutedEventArgs e)
        {
            if(TeamList.SelectionMode == ListViewSelectionMode.Multiple)
            {
                TeamList.SelectionMode = ListViewSelectionMode.Single;
            }
            else
            {
                TeamList.SelectionMode = ListViewSelectionMode.Multiple;
            }
            CmdBar.IsOpen = true;
            CmdBar.IsSticky = true;

        }

        private void Pivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((EventPivot.SelectedItem as PivotItem)?.Header.ToString() == "Lag")
            {
                CmdBar.IsOpen = true;
            }
            else
                CmdBar.IsOpen = false;
        }
    }
}
