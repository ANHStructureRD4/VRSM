using System.Collections.ObjectModel;

namespace ANH.VRSM
{
    /// <summary>
    /// The design-time data for a <see cref="AnalysisMaterialViewModel"/>
    /// </summary>
    public class AnalysisMaterialDesignModel : AnalysisMaterialViewModel
    {

        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static AnalysisMaterialDesignModel Instance => new AnalysisMaterialDesignModel();

        //public static ChatListDesignModel Instance { get { return new ChatListDesignModel(); } }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnalysisMaterialDesignModel()
        {
            MaterialObject = AnalysisMaterialObject.Ply;

            MaterialMethod = AnalysisMaterialMethod.UserDefined;

            Items = new ObservableCollection<AnalysisMaterialItemViewModel>
            {
                new AnalysisMaterialItemViewModel
                {
                    Name = "Material item 01",
                    Elastic_Modulus_11 = new TextNumericViewModel { Label = "Elastic_Modulus_11", NumericText = "0.1", Unit = "[MPa]" },
                    Elastic_Modulus_22 = new TextNumericViewModel { Label = "Elastic_Modulus_22", NumericText = "0.2", Unit = "[MPa]" },
                    IsExpanded = false,
                }
            };
        }

        #endregion
    }
}
