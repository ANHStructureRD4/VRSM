using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ANH.RACOMS
{
    /// <summary>
    /// The design-time data for a <see cref="BaseListItemViewModel"/>
    /// </summary>
    public class BaseListItemDesignModel : BaseListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static BaseListItemDesignModel Instance => new BaseListItemDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseListItemDesignModel()
        {
            Name = "Analysis Data";
            Contents = AnalysisContent.Unit;
            IsSelected = true;
        }

        #endregion
    }
}
