namespace ANH.VRSM
{
    /// <summary>
    /// The design-time data for a <see cref="AnalysisUnitViewModel"/>
    /// </summary>
    public class AnalysisUnitDesignModel : AnalysisUnitViewModel
    {

        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static AnalysisUnitDesignModel Instance => new AnalysisUnitDesignModel();

        //public static ChatListDesignModel Instance { get { return new ChatListDesignModel(); } }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnalysisUnitDesignModel()
        {
        }

        #endregion
    }
}
