namespace ANH.VRSM
{
    /// <summary>
    /// The design-time data for a <see cref="IConActionViewModel"/>
    /// </summary>
    public class IConActionDesignModel : IConActionViewModel
    {

        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static IConActionDesignModel Instance => new IConActionDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public IConActionDesignModel()
        {
            IconSource = "/Images/Icons/creat_.png";
            ActionText = "Create";
        }

        #endregion
    }
}
