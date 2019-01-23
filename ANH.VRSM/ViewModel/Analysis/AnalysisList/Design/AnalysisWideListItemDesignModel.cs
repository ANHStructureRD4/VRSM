using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ANH.RACOMS
{
    /// <summary>
    /// The design-time data for a <see cref="AnalysisListCategoryViewModel"/>
    /// </summary>
    public class AnalysisWideListItemDesignModel : AnalysisListCategoryViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static AnalysisWideListItemDesignModel Instance => new AnalysisWideListItemDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnalysisWideListItemDesignModel()
        {
            Name = "Analysis Data";
            CanExpand = true;
            IsExpanded = true;
        }

        #endregion
    }
}
