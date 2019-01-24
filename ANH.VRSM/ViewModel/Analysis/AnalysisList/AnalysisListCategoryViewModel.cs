using System.Collections.Generic;
using System.Windows.Input;
using static ANH.VRSM.DI;

namespace ANH.VRSM
{
    /// <summary>
    /// A view model for each analysis list item in the overview analysis list
    /// </summary>
    public class AnalysisListCategoryViewModel : BaseViewModel
    {
        #region public Properties
        
        /// <summary>
        /// The display name of Analysis list
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// A list of all children contained inside this item
        /// </summary>
        public AnalysisViewModel AnalysisList { get; set; }

        /// <summary>
        /// True if this item is currently selected
        /// </summary>
        public bool CanExpand { get; set; }

        /// <summary>
        /// Indicates if the current item is expanded or not
        /// </summary>
        public bool IsExpanded { get; set; }

        /// <summary>
        /// Indicates if the current item is selected or not
        /// </summary>
        public bool IsSelected { get; set; }

        #endregion

        #region Public Commands

        /// <summary>
        /// Opens the current analysis sub list
        /// </summary>
        public ICommand OpenAnalysisDataCommand { get; set; }

        #endregion

        public AnalysisListCategoryViewModel()
        {
            // Setup the children as needed
            ClearChildren();
            
            // Creat commands
            OpenAnalysisDataCommand = new RelayParameterizedCommand(OpenAnalysisData);
        }

        #region Helper Methods

        /// <summary>
        /// Removes all children from the list, adding a dummy item to show the expand icon if required
        /// </summary>
        private void ClearChildren()
        {
            //// Clear items
            //this.Children = new ObservableCollection<AnalysisListCategoryItemViewModel>();

            //// Show the expand arrow if we are not a file
            ////if (this.Type != DirectoryItemType.File)
            //    this.Children.Add(null);
        }

        #endregion

        public void OpenAnalysisData(object parameter)
        {
            IsSelected = true;

            var analysisparameter = (AnalysisListCategoryViewModel)parameter;

            if (AnalysisList == null)
                AnalysisList = new AnalysisViewModel();

            AnalysisList.TitleName = analysisparameter.Name;
            AnalysisList.AnalysisSubListVisible = true;
            AnalysisList.CurrentContent = AnalysisContent.Unit;
            AnalysisList.Items = new List<AnalysisSubListItemViewModel>
            {
                new AnalysisSubListItemViewModel
                {
                    AnalysisName = analysisparameter.Name,
                    Name = analysisparameter.Name,
                    Contents = AnalysisContent.Unit,
                    IsSelected = true
                },
                new AnalysisSubListItemViewModel
                {
                    AnalysisName = analysisparameter.Name,
                    Name = "Geometry",
                    Contents = AnalysisContent.Geometry,
                    IsSelected = false
                },
                new AnalysisSubListItemViewModel
                {
                    AnalysisName = analysisparameter.Name,
                    Name = "Loads",
                    Contents = AnalysisContent.Loads,
                    IsSelected = false
                },
                new AnalysisSubListItemViewModel
                {
                    AnalysisName = analysisparameter.Name,
                    Name = "Analysis",
                    Contents = AnalysisContent.parameter,
                    IsSelected = false
                },
                new AnalysisSubListItemViewModel
                {
                    AnalysisName = analysisparameter.Name,
                    Name = "Result",
                    Contents = AnalysisContent.Result,
                    IsSelected = false
                },
            };

            // Get contents List and data
            ViewModelAnalysis.OpenContentsList(AnalysisList);
        }

        /// <summary>
        ///  Expands this directory and finds all children
        /// </summary>
        private void Expand()
        {
            //// We cannot expand a file
            //if (this.Type == DirectoryItemType.File)
            //    return;

            //// Find all children
            //var children = DirectoryStructure.GetDirectoryContents(this.FullPath);
            //this.Children = new ObservableCollection<AnalysisSubListItemViewModel>(
            //                    children.Select(content => new DirectoryItemViewModel(content.FullPath, content.Type)));
        }
    }
}
