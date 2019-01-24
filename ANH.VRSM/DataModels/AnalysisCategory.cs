namespace ANH.VRSM
{
    /// <summary>
    /// A page of the application
    /// </summary>
    public enum AnalysisCategory
    {
        /// <summary>
        /// No analysis
        /// </summary>
        none = 0,

        /// <summary>
        /// Plain strength analysis
        /// </summary>
        PlainStrengthAnalysis = 1,

        /// <summary>
        /// Composit radius analysis
        /// </summary>
        CompositeRadiusAnalysis = 2,

        /// <summary>
        /// Sandwich panel alysis
        /// </summary>
        SandwichPanelAnalysis = 3,

        /// <summary>
        /// Joint analysis
        /// </summary>
        JointAnalysis = 4,

        /// <summary>
        /// Material library
        /// </summary>
        Materials = 5,

        /// <summary>
        /// Laminate library
        /// </summary>
        Laminate = 6,

        /// <summary>
        /// Fastener library
        /// </summary>
        Fastener = 7
    }
}
