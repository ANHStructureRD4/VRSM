namespace ANH.RACOMS
{
    /// <summary>
    /// The design-time data for a <see cref="AnalysisListItemViewModel"/>
    /// </summary>
    public class AnalysisListItemDesignModel : AnalysisListItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static AnalysisListItemDesignModel Instance => new AnalysisListItemDesignModel();

        //public static ChatListItemDesignModel Instance { get { return new ChatListItemDesignModel(); } }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnalysisListItemDesignModel()
        {
            Initials = "Plain";
            AnalysisName = "Plain Strength Analysis";
            ProfilePictureRGB = "3099c5";
            IconSource = "/Images/Icons/plainx2.png";
            Category = AnalysisCategory.PlainStrengthAnalysis;
        }

        #endregion
    }
}
