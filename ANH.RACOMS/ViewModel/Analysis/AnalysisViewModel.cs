using ANH.Core;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using static ANH.RACOMS.DI;

namespace ANH.RACOMS
{
    /// <summary>
    /// A view model for a chat message thread list
    /// </summary>
    public class AnalysisViewModel :BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The chat thread items for the list
        /// </summary>
        public List<AnalysisSubListItemViewModel> Items { get; set; }

        /// <summary>
        /// The display name of Analysis list
        /// </summary>
        public string TitleName { get; set; }

        /// <summary>
        /// True to show the Analysis sub list, false to hide it
        /// </summary>
        public bool AnalysisSubListVisible { get; set; }

        /// <summary>
        /// True if any popup menus are visible
        /// </summary>
        public bool AnyPopupVisible => AnalysisSubListVisible;

        /// <summary>
        /// True to show the Library space, false to hide it
        /// </summary>
        public bool LibrarySpaceVisible { get; set; }

        /// <summary>
        /// True to show the attachment menu, false to hide it
        /// </summary>
        public bool AttachmentMenuVisible { get; set; }


        /// <summary>
        /// A Analysis Contents
        /// </summary>
        public AnalysisContent CurrentContent { get; set; } = AnalysisContent.None;

        /// <summary>
        /// The current analysis action
        /// </summary>
        public AnalysisAction CurrentAction { get; set; } = AnalysisAction.none;

        /// <summary>
        /// The view model for the analysis unit
        /// </summary>
        public BaseViewModel ContentViewModel => SetCurrentViewModel();

        #endregion

        #region Public Commands

        /// <summary>
        /// The command for when the area outside of any popup is clicked
        /// </summary>
        public ICommand PopupClickawayCommand { get; set; }
        
        /// <summary>
        /// The command to Open the Analysis module
        /// </summary>
        public ICommand OpenAnalysisCommand { get; set; }

        /// <summary>
        /// The command to Open the Library module
        /// </summary>
        public ICommand OpenLibraryCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnalysisViewModel()
        {
            // Create commands
            PopupClickawayCommand = new RelayCommand(PopupClickaway);

            OpenAnalysisCommand = new RelayCommand(OpenAnalysis);
            OpenLibraryCommand = new RelayCommand(OpenLibrary);
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// Navigates to the specified page
        /// </summary>
        /// <param name="page"></param>
        /// <param name="viewModel">The view model, if any, to set explicitly to the new page</param>
        public BaseViewModel SetCurrentViewModel()
        {
            // Set the current view model
            if (CurrentContent == AnalysisContent.Unit)
            {
                return new AnalysisUnitViewModel()
                {
                    AnalysisTitle = TitleName,
                    Unit = AnalysisUnit.US,
                    IsEdited = (ViewModelAnalysis.CurrentAction == AnalysisAction.Create) ? true : false
                };
            }
            else if (CurrentContent == AnalysisContent.Material)
                return new AnalysisMaterialViewModel();
            else if (CurrentContent == AnalysisContent.Laminate)
                return new AnalysisLaminateViewModel();
            else if (CurrentContent == AnalysisContent.Geometry)
                return new AnalysisMaterialViewModel();
            else
                return null;
        }

        /// <summary>
        /// When the popup clickaway area is clicked hide any popups
        /// </summary>
        public void PopupClickaway()
        {
            // Hide attachment menu
            AnalysisSubListVisible = false;
        }

        /// <summary>
        /// Open the Analysis menu
        /// </summary>
        public void OpenAnalysis()
        {
            // Open Analysis module
            ViewModelApplication.AnalysisWideMenuVisible ^= true;
        }

        /// <summary>
        /// Open the Library menu
        /// </summary>
        public void OpenLibrary()
        {
            // Open Analysis module
            ViewModelApplication.LibraryWideMenuVisible ^= true;
        }

        /// <summary>
        /// If click the analysis data, open sub lists <see cref="AnalysisSubListItemViewModel"/> 
        /// </summary>
        /// <param name="parameter"></param>
        public void OpenContentsList(AnalysisViewModel parameter)
        {
            if (parameter == null)
                return;

            var analysisviewmodel = parameter;

            AnalysisSubListVisible = parameter.AnalysisSubListVisible;
            CurrentAction = parameter.CurrentAction;
            CurrentContent = parameter.CurrentContent;

            Items = parameter.Items;

            // Get analysis contents list and data
            ViewModelApplication.GoToPage(ApplicationPage.Analysis, analysisviewmodel);

        }

        /// <summary>
        /// If click the library data(material, laminate) It open detail data
        /// </summary>
        /// <param name="parameter"></param>
        public void OpenLibraryData(AnalysisViewModel parameter)
        {
            if (parameter == null)
                return;

            ViewModelApplication.LibraryWideMenuVisible = parameter.LibrarySpaceVisible;
            ViewModelApplication.AnalysisWideMenuVisible = parameter.AnalysisSubListVisible;

            var analysisviewmodel = parameter;

            // Get analysis contents list and data
            ViewModelApplication.GoToLibrary(ApplicationPage.Library, analysisviewmodel);

        }

        public void ClearList(AnalysisViewModel parameter)
        {
            parameter.Items.Clear();
        }
        #endregion
    }
}
