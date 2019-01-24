using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using static ANH.VRSM.DI;

namespace ANH.VRSM
{
    /// <summary>
    /// A view model for any popup menus
    /// </summary>
    public class AnalysisMaterialViewModel : BaseViewModel
    {
        #region Public Properties
        /// <summary>
        /// The analysis material object
        /// </summary>
        public AnalysisMaterialObject MaterialObject { get; set; }

        /// <summary>
        /// The analysis material method
        /// </summary>
        public AnalysisMaterialMethod MaterialMethod { get; set; }

        /// <summary>
        /// Analysis material item list
        /// </summary>
        public ObservableCollection<AnalysisMaterialItemViewModel> Items { get; set; }

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

        /// <summary>
        /// Default Constructor
        /// </summary>
        public AnalysisMaterialViewModel()
        {
            CreateCommand = new RelayCommand(Create);

            ImportCommand = new RelayCommand(Import);

            ModifyCommand = new RelayCommand(Modify);

            DeleteCommand = new RelayCommand(Delete);

            MaterialObject = AnalysisMaterialObject.Ply;

            MaterialMethod = AnalysisMaterialMethod.UserDefined;

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

            Items = new ObservableCollection<AnalysisMaterialItemViewModel>
            {
                new AnalysisMaterialItemViewModel
                {
                    Name = "Material item 01",
                    // Linear Elastics
                    Elastic_Modulus_11 = new TextNumericViewModel { Label = "Elastic Modulus 11", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },
                    Elastic_Modulus_22 = new TextNumericViewModel { Label = "Elastic Modulus 22", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },
                    Poisson_Ration_12 = new TextNumericViewModel { Label = "Poisson Ration 12", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },
                    Shear_Modulus_12 = new TextNumericViewModel { Label = "Shear Modulus 12", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },
                    Thickness_tply = new TextNumericViewModel { Label = "Thickness, tply", OriginalText = "0.0", NumericText = "0.0", Unit = "[mm]" },

                    //Failure_Stress
                    Tension_Stress_Limit_11 = new TextNumericViewModel { Label = "Tension Stress Limit 11", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },
                    Tension_Stress_Limit_22 = new TextNumericViewModel { Label = "Tension Stress Limit 22", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },
                    Compress_Stress_Limit_11 = new TextNumericViewModel { Label = "Compress Stress Limit 11", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },
                    Compress_Stress_Limit_22 = new TextNumericViewModel { Label = "Compress Stress Limit 22", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },
                    Shear_Stress_Limit_12 = new TextNumericViewModel { Label = "Shear Stress Limit 12", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },

                    Tension_Stress_Limit_33 = new TextNumericViewModel { Label = "Tension Stress Limit 33", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },
                    Compress_Stress_Limit_33 = new TextNumericViewModel { Label = "Compress Stress Limit 33", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },
                    Interlaminate_Shear_Stress_Limit_13 = new TextNumericViewModel { Label = "Inter-laminate Shear Stress Limit 13", NumericText = "0.0", OriginalText = "0.0", Unit = "[MPa]" },


                    //Failure_Strain
                    Tension_Strain_Limit_11 = new TextNumericViewModel { Label = "Tension Strain Limit 11", OriginalText = "0.0", NumericText = "0.0", Unit = "[mm/mm]" },
                    Tension_Strain_Limit_22 = new TextNumericViewModel { Label = "Tension Strain Limit 22", OriginalText = "0.0", NumericText = "0.0", Unit = "[mm/mm]" },
                    Compress_Strain_Limit_11 = new TextNumericViewModel { Label = "Compress Strain Limit 11", OriginalText = "0.0", NumericText = "0.0", Unit = "[mm/mm]" },
                    Compress_Strain_Limit_22 = new TextNumericViewModel { Label = "Compress Strain Limit 22", OriginalText = "0.0", NumericText = "0.0", Unit = "[mm/mm]" },
                    Shear_Strain_Limit_12 = new TextNumericViewModel { Label = "Shear Strain Limit 12", OriginalText = "0.0", NumericText = "0.0", Unit = "[mm/mm]" },

                    IsSelected = true,
                    IsExpanded = false,
                    IsEdited = false,
                },
                new AnalysisMaterialItemViewModel
                {
                    Name = "Material item 02",
                    // Linear Elastics
                    Elastic_Modulus_11 = new TextNumericViewModel { Label = "Elastic Modulus 11", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },
                    Elastic_Modulus_22 = new TextNumericViewModel { Label = "Elastic Modulus 22", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },
                    Poisson_Ration_12 = new TextNumericViewModel { Label = "Poisson Ration 12", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },
                    Shear_Modulus_12 = new TextNumericViewModel { Label = "Shear Modulus 12", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },
                    Thickness_tply = new TextNumericViewModel { Label = "Thickness, tply", OriginalText = "0.0", NumericText = "0.0", Unit = "[mm]" },

                    //Failure_Stress
                    Tension_Stress_Limit_11 = new TextNumericViewModel { Label = "Tension Stress Limit 11", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },
                    Tension_Stress_Limit_22 = new TextNumericViewModel { Label = "Tension Stress Limit 22", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },
                    Compress_Stress_Limit_11 = new TextNumericViewModel { Label = "Compress Stress Limit 11", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },
                    Compress_Stress_Limit_22 = new TextNumericViewModel { Label = "Compress Stress Limit 22", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },
                    Shear_Stress_Limit_12 = new TextNumericViewModel { Label = "Shear Stress Limit 12", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },

                    Tension_Stress_Limit_33 = new TextNumericViewModel { Label = "Tension Stress Limit 33", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },
                    Compress_Stress_Limit_33 = new TextNumericViewModel { Label = "Compress Stress Limit 33", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },
                    Interlaminate_Shear_Stress_Limit_13 = new TextNumericViewModel { Label = "Inter-laminate Shear Stress Limit 13", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]" },


                    //Failure_Strain
                    Tension_Strain_Limit_11 = new TextNumericViewModel { Label = "Tension Strain Limit 11", OriginalText = "0.0", NumericText = "0.0", Unit = "[mm/mm]" },
                    Tension_Strain_Limit_22 = new TextNumericViewModel { Label = "Tension Strain Limit 22", OriginalText = "0.0", NumericText = "0.0", Unit = "[mm/mm]" },
                    Compress_Strain_Limit_11 = new TextNumericViewModel { Label = "Compress Strain Limit 11", OriginalText = "0.0", NumericText = "0.0", Unit = "[mm/mm]" },
                    Compress_Strain_Limit_22 = new TextNumericViewModel { Label = "Compress Strain Limit 22", OriginalText = "0.0", NumericText = "0.0", Unit = "[mm/mm]" },
                    Shear_Strain_Limit_12 = new TextNumericViewModel { Label = "Shear Strain Limit 12", OriginalText = "0.0", NumericText = "0.0", Unit = "[mm/mm]" },

                    IsSelected = true,
                    IsExpanded = false,
                    IsEdited = false,
                }
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

            Items = new ObservableCollection<AnalysisMaterialItemViewModel>
            {
                new AnalysisMaterialItemViewModel
                {
                    Name = "Input material name text",
                    // Linear Elastics
                    Elastic_Modulus_11 = new TextNumericViewModel { Label = "Elastic Modulus 11", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]", Editing = true },
                    Elastic_Modulus_22 = new TextNumericViewModel { Label = "Elastic Modulus 22", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]", Editing = true },
                    Poisson_Ration_12 = new TextNumericViewModel { Label = "Poisson Ration 12", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]", Editing = true },
                    Shear_Modulus_12 = new TextNumericViewModel { Label = "Shear Modulus 12", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]", Editing = true },
                    Thickness_tply = new TextNumericViewModel { Label = "Thickness, tply", OriginalText = "0.0", NumericText = "0.0", Unit = "[mm]", Editing = true },

                    //Failure_Stress
                    Tension_Stress_Limit_11 = new TextNumericViewModel { Label = "Tension Stress Limit 11", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]", Editing = true },
                    Tension_Stress_Limit_22 = new TextNumericViewModel { Label = "Tension Stress Limit 22", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]", Editing = true },
                    Compress_Stress_Limit_11 = new TextNumericViewModel { Label = "Compress Stress Limit 11", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]", Editing = true },
                    Compress_Stress_Limit_22 = new TextNumericViewModel { Label = "Compress Stress Limit 22", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]", Editing = true },
                    Shear_Stress_Limit_12 = new TextNumericViewModel { Label = "Shear Stress Limit 12", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]", Editing = true },

                    Tension_Stress_Limit_33 = new TextNumericViewModel { Label = "Tension Stress Limit 33", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]", Editing = true },
                    Compress_Stress_Limit_33 = new TextNumericViewModel { Label = "Compress Stress Limit 33", OriginalText = "0.0", NumericText = "0.0", Unit = "[MPa]", Editing = true },
                    Interlaminate_Shear_Stress_Limit_13 = new TextNumericViewModel { Label = "Inter-laminate Shear Stress Limit 13", NumericText = "0.0", OriginalText = "0.0", Unit = "[MPa]", Editing = true },

                    //Failure_Strain
                    Tension_Strain_Limit_11 = new TextNumericViewModel { Label = "Tension Strain Limit 11", OriginalText = "0.0", NumericText = "0.0", Unit = "[mm/mm]", Editing = true },
                    Tension_Strain_Limit_22 = new TextNumericViewModel { Label = "Tension Strain Limit 22", OriginalText = "0.0", NumericText = "0.0", Unit = "[mm/mm]", Editing = true },
                    Compress_Strain_Limit_11 = new TextNumericViewModel { Label = "Compress Strain Limit 11", OriginalText = "0.0", NumericText = "0.0", Unit = "[mm/mm]", Editing = true },
                    Compress_Strain_Limit_22 = new TextNumericViewModel { Label = "Compress Strain Limit 22", OriginalText = "0.0", NumericText = "0.0", Unit = "[mm/mm]", Editing = true },
                    Shear_Strain_Limit_12 = new TextNumericViewModel { Label = "Shear Strain Limit 12", OriginalText = "0.0", NumericText = "0.0", Unit = "[mm/mm]", Editing = true },

                    IsSelected = true,
                    IsExpanded = true,
                    IsEdited = true,
                },
            };
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

            foreach (var item in Items)
            {
                if (item.IsExpanded)
                {
                    item.Elastic_Modulus_11.Editing = true;
                    item.Elastic_Modulus_22.Editing = true;
                    item.Poisson_Ration_12.Editing = true;
                    item.Shear_Modulus_12.Editing = true;
                    item.Thickness_tply.Editing = true;

                    item.Tension_Stress_Limit_11.Editing = true;
                    item.Tension_Stress_Limit_22.Editing = true;
                    item.Compress_Stress_Limit_11.Editing = true;
                    item.Compress_Stress_Limit_22.Editing = true;
                    item.Shear_Stress_Limit_12.Editing = true;

                    item.Tension_Stress_Limit_33.Editing = true;
                    item.Compress_Stress_Limit_33.Editing = true;
                    item.Interlaminate_Shear_Stress_Limit_13.Editing = true;

                    item.Tension_Strain_Limit_11.Editing = true;
                    item.Tension_Strain_Limit_22.Editing = true;
                    item.Compress_Strain_Limit_11.Editing = true;
                    item.Compress_Strain_Limit_22.Editing = true;
                    item.Shear_Strain_Limit_12.Editing = true;
                }
            }
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
