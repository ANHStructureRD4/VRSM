using System.Collections.Generic;
using System.Windows.Input;
using static ANH.RACOMS.DI;

namespace ANH.RACOMS
{
    /// <summary>
    /// A view model for the overview analysis Wide list
    /// </summary>
    public class AnalysisWideListViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The Search text
        /// </summary>
        public string SearchText { get; set; } = "Search";

        /// <summary>
        /// The analysis Wide list items for the Analysis Content
        /// </summary>
        public List<AnalysisListCategoryViewModel> AnalysisDatas { get; set; }

        /// <summary>
        /// The analysis execution list
        /// </summary>
        public List<AnalysisListCategoryViewModel> AnalysisExecutions { get; set; }

        /// <summary>
        /// The Create of Analysis Action
        /// </summary>
        public IConActionViewModel Create { get; set; }

        /// <summary>
        /// The Import of Analysis Action
        /// </summary>
        public IConActionViewModel Import { get; set; }

        /// <summary>
        /// The Modify of Analysis Action
        /// </summary>
        public IConActionViewModel Modify { get; set; }

        /// <summary>
        /// The Delete of Analysis Action
        /// </summary>
        public IConActionViewModel Delete { get; set; }

        #endregion

        #region Public Commands

        /// <summary>
        /// Create new material item
        /// </summary>
        public ICommand CreateCommand { get; set; }

        /// <summary>
        /// Import Database from the material item lists of Excel template data
        /// </summary>
        public ICommand ImportCommand { get; set; }

        /// <summary>
        /// The current item into edit mode
        /// </summary>
        public ICommand ModifyCommand { get; set; }

        /// <summary>
        /// Delete the material item
        /// </summary>
        public ICommand DeleteCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public AnalysisWideListViewModel()
        {
            CreateCommand = new RelayCommand(Creatcmd);

            ImportCommand = new RelayCommand(Importcmd);

            ModifyCommand = new RelayCommand(Modifycmd);

            DeleteCommand = new RelayCommand(Deletecmd);
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// the current item into edit mode and the text input controls are empty
        /// </summary>
        public void Creatcmd()
        {
            if (ViewModelAnalysis.ContentViewModel is AnalysisUnitViewModel vm)
            {
                vm.IsEdited = true;
            }
        }

        /// <summary>
        /// the current item into edit mode
        /// </summary>
        public void Modifycmd()
        {
            
        }

        /// <summary>
        /// Some material create data from excel template file
        /// </summary>
        public void Importcmd()
        {

        }

        /// <summary>
        /// The checked material items are deleted
        /// </summary>
        public void Deletecmd()
        {

        }

        #endregion

    }
}