namespace ANH.RACOMS
{
    /// <summary>
    /// The design-time data for a <see cref="AnalysisViewModel"/>
    /// </summary>
    public class AnalysisDesignModel : AnalysisViewModel
    {

        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static AnalysisDesignModel Instance => new AnalysisDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnalysisDesignModel()
        {
            //ContentViewModel = new AnalysisUnitViewModel()
            //{
            //    Unit = AnalysisUnit.SI,
            //};
        }

        #endregion
    }
}
