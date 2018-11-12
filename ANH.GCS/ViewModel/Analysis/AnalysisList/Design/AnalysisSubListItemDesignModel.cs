namespace ANH.GCS
{
    /// <summary>
    /// The design-time data for a <see cref="AnalysisSubListItemViewModel"/>
    /// </summary>
    public class AnalysisSubListItemDesignModel : AnalysisSubListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static AnalysisSubListItemDesignModel Instance => new AnalysisSubListItemDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnalysisSubListItemDesignModel()
        {
            //Name = "Unit";
            //Contents = AnalysisContent.Unit;
        }

        #endregion
    }
}
