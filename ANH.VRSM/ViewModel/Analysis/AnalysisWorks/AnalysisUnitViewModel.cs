using System.Collections.Generic;

namespace ANH.RACOMS
{
    /// <summary>
    /// A view model for any popup menus
    /// </summary>
    public class AnalysisUnitViewModel : BaseViewModel
    {
        /// <summary>
        /// The Icon action name
        /// </summary>
        public string AnalysisTitle { get; set; }

        /// <summary>
        /// The analysis unit
        /// </summary>
        public AnalysisUnit Unit { get; set; }

        /// <summary>
        /// Indicates if the current item is in edited or not
        /// </summary>
        public bool IsEdited { get; set; }

        #region Constructor

        public AnalysisUnitViewModel()
        {
        }

        #endregion
    }
}
