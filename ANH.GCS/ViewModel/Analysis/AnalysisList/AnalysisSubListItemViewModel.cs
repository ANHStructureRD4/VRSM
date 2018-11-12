using ANH.Core;
using System.Collections.Generic;
using System.Windows.Input;
using static ANH.GCS.DI;

namespace ANH.GCS
{
    /// <summary>
    /// A view model for each analysis list item in the overview analysis list
    /// </summary>
    public class AnalysisSubListItemViewModel : BaseViewModel
    {
        #region public Properties

        /// <summary>
        /// The display name of Analysis list
        /// </summary>
        public string AnalysisName { get; set; }

        /// <summary>
        /// The display name of Analysis Sub or Detail
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The count of Analysis Data
        /// </summary>
        public int count { get; set; }

        /// <summary>
        /// True if this item is currently selected
        /// </summary>
        public bool IsSelected { get; set; }

        /// <summary>
        /// A Analysis Contents
        /// </summary>
        public AnalysisContent Contents { get; set; }

        /// <summary>
        /// The icon source of local storage
        /// </summary>
        public string IconSource { get; set; }

        #endregion

        #region Public Commands

        /// <summary>
        /// The command for when the Analysis content button is clicked
        /// </summary>
        public ICommand AnalysisContentClickCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnalysisSubListItemViewModel()
        {
            // Create commands
            AnalysisContentClickCommand = new RelayParameterizedCommand(AnalysisContentClick);
        }
        #endregion

        #region Command Methods
        /// <summary>
        /// When the content list item is clicked, anlaysiswork page is update
        /// </summary>
        /// <param name="parameter">Analysis content</param>
        public void AnalysisContentClick(object parameter)
        {
            if (parameter == null)
                return;

            var analysisparameter = (AnalysisSubListItemViewModel)parameter;

            var analysisviewmodel = new AnalysisViewModel
            {
                TitleName = analysisparameter.AnalysisName,
                AnalysisSubListVisible = true,
                CurrentContent = analysisparameter.Contents,
                Items = new List<AnalysisSubListItemViewModel>
                        {
                            new AnalysisSubListItemViewModel
                            {
                                AnalysisName = analysisparameter.AnalysisName,
                                Name = analysisparameter.AnalysisName,
                                Contents = AnalysisContent.Unit,
                                IsSelected = analysisparameter.Contents == AnalysisContent.Unit
                            },
                            new AnalysisSubListItemViewModel
                            {
                                AnalysisName = analysisparameter.AnalysisName,
                                Name = "Geometry",
                                Contents = AnalysisContent.Geometry,
                                IsSelected = analysisparameter.Contents == AnalysisContent.Geometry
                            },
                            new AnalysisSubListItemViewModel
                            {
                                AnalysisName = analysisparameter.AnalysisName,
                                Name = "Loads",
                                Contents = AnalysisContent.Loads,
                                IsSelected = analysisparameter.Contents == AnalysisContent.Loads
                            },
                            new AnalysisSubListItemViewModel
                            {
                                AnalysisName = analysisparameter.AnalysisName,
                                Name = "Analysis",
                                Contents = AnalysisContent.parameter,
                                IsSelected = analysisparameter.Contents == AnalysisContent.parameter
                            },
                            new AnalysisSubListItemViewModel
                            {
                                AnalysisName = analysisparameter.AnalysisName,
                                Name = "Result",
                                Contents = AnalysisContent.Result,
                                IsSelected = analysisparameter.Contents == AnalysisContent.Result
                            },
                        },
            };

            // Get analysis content List and data
            ViewModelApplication.GoToPage(ApplicationPage.Analysis, analysisviewmodel);
        }
        #endregion
    }
}
