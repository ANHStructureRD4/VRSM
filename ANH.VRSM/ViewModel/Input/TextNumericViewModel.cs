using System;
using System.Windows.Input;

namespace ANH.VRSM
{
    /// <summary>
    /// The view model for a text entry to edit a numeric value
    /// </summary>
    public class TextNumericViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The label to identify what this value is for
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// The numeric text
        /// </summary>
        public string NumericText { get; set; }

        /// <summary>
        /// The current saved value
        /// </summary>
        public string OriginalText { get; set; }

        /// <summary>
        /// The unit of numeric value
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Indicates if the current text is in edit mode
        /// </summary>
        public bool Editing { get; set; }

        #endregion
    }
}
