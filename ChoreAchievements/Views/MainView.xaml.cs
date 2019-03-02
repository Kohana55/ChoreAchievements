using System.Windows.Controls;
using ChoreAchievements.ViewModels;

namespace ChoreAchievements.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : UserControl
    {

        public MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
            set
            {
                DataContext = value;
                _ProfileView.DataContext = value.profileVM;
                _ChoreView.DataContext = value.choreVM;
                _AchievementView.DataContext = value.achievementsVM;
                _MenuView.DataContext = value.menuVM;
            }
        }

        public MainView()
        {
            
            InitializeComponent();
            ViewModel = new MainViewModel();
        }
    }
}
