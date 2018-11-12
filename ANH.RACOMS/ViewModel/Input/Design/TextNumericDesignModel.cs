namespace ANH.RACOMS
{
    /// <summary>
    /// The design-time data for a <see cref="TextNumericViewModel"/>
    /// </summary>
    public class TextNumericDesignModel : TextNumericViewModel
    {

        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static TextNumericDesignModel Instance => new TextNumericDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public TextNumericDesignModel()
        {
            Label = "Name";
            NumericText = "Input number";
            Unit = "[MPa]";
        }

        #endregion
    }
}
