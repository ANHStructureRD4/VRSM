using System.Collections.Generic;
using System.Windows.Input;

namespace ANH.RACOMS
{
    /// <summary>
    /// A view model for any popup menus
    /// </summary>
    public class AnalysisMaterialItemViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The Material Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The Material Linear Elastic information: Elastic modulus 11
        /// </summary>
        public TextNumericViewModel Elastic_Modulus_11 { get; set; }

        /// <summary>
        /// The Material Linear Elastic information: Elastic modulus 22
        /// </summary>
        public TextNumericViewModel Elastic_Modulus_22 { get; set; }

        /// <summary>
        /// The Material Linear Elastic information: Poisson Raito 12
        /// </summary>
        public TextNumericViewModel Poisson_Ration_12 { get; set; }

        /// <summary>
        /// The Material Linear Elastic information: Shear modulus 12
        /// </summary>
        public TextNumericViewModel Shear_Modulus_12 { get; set; }

        /// <summary>
        /// The Material Linear Elastic information: Thickness, tply
        /// </summary>
        public TextNumericViewModel Thickness_tply { get; set; }

        /// <summary>
        /// The Material Failure+In_Stress information: Tension Stress Limit 11
        /// </summary>
        public TextNumericViewModel Tension_Stress_Limit_11 { get; set; }

        /// <summary>
        /// The Material Failure+In_Stress information: Tension Stress Limit 22
        /// </summary>
        public TextNumericViewModel Tension_Stress_Limit_22 { get; set; }

        /// <summary>
        /// The Material Failure+In_Stress information: Compress Stress Limit 11
        /// </summary>
        public TextNumericViewModel Compress_Stress_Limit_11 { get; set; }

        /// <summary>
        /// The Material Failure+In_Stress information: Compress Stress Limit 11
        /// </summary>
        public TextNumericViewModel Compress_Stress_Limit_22 { get; set; }

        /// <summary>
        /// The Material Failure+In_Stress information: Shear Stress Limit 12
        /// </summary>
        public TextNumericViewModel Shear_Stress_Limit_12 { get; set; }

        /// <summary>
        /// The Material Failure+Out_Stress information: Tension Stress Limit 33
        /// </summary>
        public TextNumericViewModel Tension_Stress_Limit_33 { get; set; }

        /// <summary>
        /// The Material Failure+Out_Stress information: Tension Stress Limit 33
        /// </summary>
        public TextNumericViewModel Compress_Stress_Limit_33 { get; set; }

        /// <summary>
        /// The Material Failure+Out_Stress information: Inter-Laminate shear Stress Limit 13
        /// </summary>
        public TextNumericViewModel Interlaminate_Shear_Stress_Limit_13 { get; set; }

        /// <summary>
        /// The Material Failure+In_Strain information: Tension Strain Limit 11
        /// </summary>
        public TextNumericViewModel Tension_Strain_Limit_11 { get; set; }

        /// <summary>
        /// The Material Failure+In_Strain information: Tension Strain Limit 22
        /// </summary>
        public TextNumericViewModel Tension_Strain_Limit_22 { get; set; }

        /// <summary>
        /// The Material Failure+In_Strain information: Compress Strain Limit 11
        /// </summary>
        public TextNumericViewModel Compress_Strain_Limit_11 { get; set; }

        /// <summary>
        /// The Material Failure+In_Strain information: Compress Strain Limit 11
        /// </summary>
        public TextNumericViewModel Compress_Strain_Limit_22 { get; set; }

        /// <summary>
        /// The Material Failure+In_Strain information: Shear Strain Limit 12
        /// </summary>
        public TextNumericViewModel Shear_Strain_Limit_12 { get; set; }

        /// <summary>
        /// Indicates if the current item is expanded or not
        /// </summary>
        public bool IsExpanded { get; set; }

        /// <summary>
        /// Failure selection
        /// </summary>
        public bool IsSelected { get; set; }

        /// <summary>
        /// Indicates if the current item is in edited or not
        /// </summary>
        public bool IsEdited { get; set; }

        #endregion

        #region Public Commands

        /// <summary>
        /// The command for when the user clicks the Material header list
        /// </summary>
        public ICommand MaterialHeaderListCommand { get; set; }

        #endregion


        #region Constructor

        public AnalysisMaterialItemViewModel()
        {
            MaterialHeaderListCommand = new RelayCommand(Expand);
        }

        #endregion

        #region Command Methods

        public void Expand()
        {
            IsExpanded ^= true;
        }

        #endregion
    }
}
