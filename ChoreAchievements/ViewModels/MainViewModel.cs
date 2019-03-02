using ChoreAchievements.Model;
using ChoreAchievements.UtilityObjects;
using System.Windows;

namespace ChoreAchievements.ViewModels
{
    public class MainViewModel : BindableBase
    {


        Main main = new Main();

        public ProfileViewModel profileVM = new ProfileViewModel();
        public ChoreViewModel choreVM = new ChoreViewModel();
        public AchievementsViewModel achievementsVM = new AchievementsViewModel();
        public SetupViewModel setupVM = new SetupViewModel();
        public MenuViewModel menuVM = new MenuViewModel();

        #region Properties
        /// <summary>
        /// Set to change the current page
        /// </summary>
        public Enums.Views CurrentPage
        {
            get { return currentPage; }
            set
            {
                currentPage = value;
                UpdateView();
            }
        }
        private Enums.Views currentPage;
        #endregion


        public MainViewModel()
        {
            menuVM.OnMenuClick += MenuVM_OnMenuClick;
        }

        private void MenuVM_OnMenuClick(object sender, Enums.Views e)
        {
            CurrentPage = e;
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateView()
        {
            profileVM.IsVisible = CurrentPage == Enums.Views.Profile ? Visibility.Visible : Visibility.Hidden;
            choreVM.IsVisible = CurrentPage == Enums.Views.Chores ? Visibility.Visible : Visibility.Hidden;
        }

    }
}
