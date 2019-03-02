using ChoreAchievements.UtilityObjects;
using System.Windows.Input;

namespace ChoreAchievements.ViewModels
{
    /// <summary>
    /// Menu View Model
    /// </summary>
    public class MenuViewModel : BindableBase
    {

        /// <summary>
        /// Current page to display
        /// </summary>
        public Enums.Views CurrentPage;

        /// <summary>
        /// COMMANDS
        /// Each command is bound to its button in the MenuView.xaml
        /// This binding is possible because we have assigned the MenuView's Datacontex to this ViewModel
        /// Each command calls a method in this class
        /// </summary>
        #region Commands
        public ICommand ProfileSelect
        {
            get { return profileSelect ?? (profileSelect = new DelegateCommand(ProfileSelected)); }
        }
        private ICommand profileSelect;

        public ICommand ChoreSelect
        {
            get { return choreSelect ?? (choreSelect = new DelegateCommand(ChoresSelected)); }
        }
        private ICommand choreSelect;

        public ICommand AchievementsSelect
        {
            get { return achievementsSelect ?? (achievementsSelect = new DelegateCommand(AchievementsSelected)); }
        }
        private ICommand achievementsSelect;

        public ICommand SetupSelect
        {
            get { return setupSelect ?? (setupSelect = new DelegateCommand(SetupSelected)); }
        }
        private ICommand setupSelect;
        #endregion Commands

        #region Constructor
        public MenuViewModel() { }
        #endregion Constructor

        #region Methods
        public void ProfileSelected()
        {
            CurrentPage = Enums.Views.Profile;
            OnMenuClick?.Invoke(this, CurrentPage);
        }

        public void ChoresSelected()
        {
            CurrentPage = Enums.Views.Chores;
            OnMenuClick?.Invoke(this, CurrentPage);
        }

        public void AchievementsSelected()
        {
            CurrentPage = Enums.Views.Achievements;
            OnMenuClick?.Invoke(this, CurrentPage);
        }

        public void SetupSelected()
        {
            CurrentPage = Enums.Views.Setup;
            OnMenuClick?.Invoke(this, CurrentPage);
        }
        #endregion Methods

        #region EventandDelegate
        public delegate void OnMenuClickEventHandler(object sender, Enums.Views e);
        public event OnMenuClickEventHandler OnMenuClick;
        #endregion EventandDelegate
    }
}
