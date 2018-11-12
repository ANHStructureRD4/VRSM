 using System.Collections.Generic;
using System.Windows.Input;
using static ANH.RACOMS.DI;

namespace ANH.RACOMS
{
    /// <summary>
    /// A view model for analysis laminate
    /// </summary>
    public class AnalysisLaminateViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// Analysis Workspace visible
        /// </summary>
        public bool AnalysisWorkSpaceVisible { get; set; } = false;

        /// <summary>
        /// The Create of Analysis Action
        /// </summary>
        public IConActionViewModel IconCreate { get; set; }

        /// <summary>
        /// The Import of Analysis Action
        /// </summary>
        public IConActionViewModel IconImport { get; set; }

        /// <summary>
        /// The Modify of Analysis Action
        /// </summary>
        public IConActionViewModel IconModify { get; set; }

        /// <summary>
        /// The Delete of Analysis Action
        /// </summary>
        public IConActionViewModel IconDelete { get; set; }

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

        public AnalysisLaminateViewModel()
        {
            CreateCommand = new RelayCommand(Create);

            ImportCommand = new RelayCommand(Import);

            ModifyCommand = new RelayCommand(Modify);

            DeleteCommand = new RelayCommand(Delete);

            IconCreate = new IConActionViewModel
            {
                IconSource = "/Images/Icons/creat_.png",
                IconHoverSource = "/Images/Icons/creat.png",
                IconSelectSource = "/Images/Icons/creat_select.png",
                ActionText = "Create",
                IsAction = AnalysisAction.Create
            };

            IconImport = new IConActionViewModel
            {
                IconSource = "/Images/Icons/import_.png",
                IconHoverSource = "/Images/Icons/import.png",
                IconSelectSource = "/Images/Icons/import_select.png",
                ActionText = "Import",
                IsAction = AnalysisAction.Import
            };

            IconModify = new IConActionViewModel
            {
                IconSource = "/Images/Icons/modify_.png",
                IconHoverSource = "/Images/Icons/modify.png",
                IconSelectSource = "/Images/Icons/modify_select.png",
                ActionText = "Modify",
                IsAction = AnalysisAction.Modify
            };

            IconDelete = new IConActionViewModel
            {
                IconSource = "/Images/Icons/delete_.png",
                IconHoverSource = "/Images/Icons/delete.png",
                IconSelectSource = "/Images/Icons/delete_select.png",
                ActionText = "Delete",
                IsAction = AnalysisAction.Delete
            };
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// the current item into edit mode and the text input controls are empty
        /// </summary>
        public void Create()
        {
            ViewModelAnalysis.CurrentAction = AnalysisAction.Create;


            IconCreate.IsSelect = true;
            IconModify.IsSelect = false;
            IconImport.IsSelect = false;
            IconDelete.IsSelect = false;
        }

        /// <summary>
        /// the current item into edit mode
        /// </summary>
        public void Modify()
        {
            ViewModelAnalysis.CurrentAction = AnalysisAction.Modify;
            IconCreate.IsSelect = false;
            IconModify.IsSelect = true;
            IconImport.IsSelect = false;
            IconDelete.IsSelect = false;
        }

        /// <summary>
        /// Some material create data from excel template file
        /// </summary>
        public void Import()
        {
            ViewModelAnalysis.CurrentAction = AnalysisAction.Import;
            IconCreate.IsSelect = false;
            IconModify.IsSelect = false;
            IconImport.IsSelect = true;
            IconDelete.IsSelect = false;
        }

        /// <summary>
        /// The checked material items are deleted
        /// </summary>
        public void Delete()
        {
            ViewModelAnalysis.CurrentAction = AnalysisAction.Delete;
            IconCreate.IsSelect = false;
            IconModify.IsSelect = false;
            IconImport.IsSelect = false;
            IconDelete.IsSelect = true;
        }

        #endregion
    }
}
