using System;
using System.Windows.Input;

namespace ANH.RACOMS
{
    /// <summary>
    ///  The Sidemenu state as a view model
    /// </summary>
    public class SideMenuViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// True if the AnalysisList menu should be shown
        /// </summary>
        public bool AnalysisListVisible { get; set; } = true;

        /// <summary>
        /// True if This Header button is currently selected
        /// </summary>
        public bool IsSelected { get; set; }

        #endregion

        #region Public Commands

        /// <summary>
        /// The command to Open the AnalysisList menu
        /// </summary>
        public ICommand AnalysisListCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public SideMenuViewModel()
        {
            // Create commands
            AnalysisListCommand = new RelayCommand(Open);

        }

        #endregion

        /// <summary>
        /// Open the AnalysisList menu
        /// </summary>
        public void Open()
        {
            // Open AnalysisList menu
            AnalysisListVisible ^= true;
        }
    }
}
