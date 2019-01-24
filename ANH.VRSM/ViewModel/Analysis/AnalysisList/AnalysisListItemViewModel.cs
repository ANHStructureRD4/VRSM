using ANH.Core;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using static ANH.VRSM.DI;

namespace ANH.VRSM
{
    /// <summary>
    /// A view model for each analysis list item in the overview analysis list
    /// </summary>
    public class AnalysisListItemViewModel : BaseViewModel
    {
        #region Private Members

        /// <summary>
        /// Icon source path
        /// </summary>
        private string mIconSource;

        #endregion

        #region public Properties
        /// <summary>
        /// The display name of Analysis list
        /// </summary>
        public string AnalysisName { get; set; }

        /// <summary>
        /// The initials to show for the profile picture background
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// The RGB values (in hex) for the background color of the profile picture
        /// For example FF00FF for Red and Blue mixed
        /// </summary>
        public string ProfilePictureRGB { get; set; }

        /// <summary>
        /// The RGB values (in hex) for the background color of the profile picture
        /// For example FF00FF for Red and Blue mixed
        /// </summary>
        public AnalysisCategory Category { get; set; }

        /// <summary>
        /// True if this item is currently selected
        /// </summary>
        public bool IsSelect { get; set; }

        /// <summary>
        /// A list of all children contained inside this item
        /// </summary>
        public List<AnalysisListCategoryViewModel> AnalysisDatas { get; set; }

        /// <summary>
        /// True if this item is in right side menu
        /// </summary>
        public bool LibraryItem { get; set; }


        /// <summary>
        /// The icon source of local storage
        /// </summary>
        public string IconSource
        {
            get
            {
                if (IsSelect)
                    return mIconSource.Replace("_@2x.png", "@2x.png");
                else
                    return mIconSource.Replace("@2x.png", "_@2x.png");
            }
            set
            {
                // If value hasn't changed, return
                if (value == mIconSource)
                    return;

                // Update value
                mIconSource = value;
            }
        }

        #endregion

        #region Public Commands

        /// <summary>
        /// Opens the current analysis wide list
        /// </summary>
        public ICommand OpenWideListCommand { get; set; }

        #endregion

        #region constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnalysisListItemViewModel()
        {
            OpenWideListCommand = new RelayParameterizedCommand(OpenWideList);
        }

        #endregion

        public void OpenWideList(object parameter)
        {            
            ViewModelApplication.CurrentCategory = Category;
            if (parameter == null)
            {
                ViewModelApplication.AnalysisWideMenuVisible = true;
                ViewModelApplication.LibraryWideMenuVisible = true;
                return;
            }

            var analysisparameter = (AnalysisListCategoryItemViewModel)parameter;

            AnalysisViewModel analysisviewmodel = new AnalysisViewModel();

            if (LibraryItem)
            {
                analysisviewmodel.LibrarySpaceVisible = true;
                analysisviewmodel.AnalysisSubListVisible = false;
                ViewModelAnalysis.OpenContentsList(analysisviewmodel);

                analysisviewmodel.TitleName = analysisparameter.Name;
                analysisviewmodel.CurrentContent = analysisparameter.Content;
                
                
                // Open library data
                
                ViewModelAnalysis.OpenLibraryData(analysisviewmodel);
            }
            
        }
    }
}
