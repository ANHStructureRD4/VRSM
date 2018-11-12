namespace ANH.GCS
{
    /// <summary>
    /// The design-time data for a <see cref="PasswordEntryViewModel"/>
    /// </summary>
    public class PasswordEntryDesignModel : PasswordEntryViewModel
    {

        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static PasswordEntryViewModel Instance => new PasswordEntryViewModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public PasswordEntryDesignModel()
        {
            Label = "Name";
            FakePassword = "********";
        }

        #endregion
    }
}
