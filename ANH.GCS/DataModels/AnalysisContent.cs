namespace ANH.GCS
{
    /// <summary>
    /// A page of the application
    /// </summary>
    public enum AnalysisContent
    {
        /// <summary>
        /// No Contents
        /// </summary>
        None = 0,

        /// <summary>
        /// Unit Contents
        /// </summary>
        Unit = 1,

        /// <summary>
        /// Material Contents
        /// </summary>
        Material = 2,

        /// <summary>
        /// Laminate Contents
        /// </summary>
        Laminate = 3,

        /// <summary>
        /// Fastner
        /// </summary>
        Fastener = 4,

        /// <summary>
        /// Geometry Contents
        /// </summary>
        Geometry = 5,

        /// <summary>
        /// Loads Contents
        /// </summary>
        Loads = 6,

        /// <summary>
        /// Analysis Contents
        /// </summary>
        parameter = 7,

        /// <summary>
        /// Result Contents
        /// </summary>
        Result = 8
    }

    public enum AnalysisUnit
    {
        SI = 0,
        US = 1
    }

    public enum AnalysisMaterialObject
    {
        Ply = 0,
        Core = 1
    }

    public enum AnalysisMaterialMethod
    {
        UserDefined = 0,
        MaterialLibrary = 1
    }

    public enum AnalysisAction
    {
        // no action
        none = 0,
        // create action
        Create = 1,
        // import action
        Import = 2,
        // modify action
        Modify = 3,
        // delete action
        Delete = 4
    }
}
