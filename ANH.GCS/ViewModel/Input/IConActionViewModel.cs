using System;
using System.Windows.Input;

namespace ANH.GCS
{
    /// <summary>
    /// The view model for a text entry to edit a numeric value
    /// </summary>
    public class IConActionViewModel : BaseViewModel
    {
        //#region Private Members

        //private bool mSelected;

        //#endregion

        #region Public Properties

        /// <summary>
        /// The image source of Icon in local storage
        /// </summary>
        public string IconSource { get; set; }

        /// <summary>
        /// When if Mouse hover, chages icon source
        /// </summary>
        public string IconHoverSource { get; set; }

        /// <summary>
        /// When if the Item is Selected, chages icon source
        /// </summary>
        public string IconSelectSource { get; set; }

        /// <summary>
        /// The Icon action name
        /// </summary>
        public string ActionText { get; set; }

        public AnalysisAction IsAction { get; set; }

        /// <summary>
        /// True if this item is currently selected
        /// </summary>
        public bool IsSelect { get; set; }
        //{
        //    get => ViewModelAnalysis.CurrentAction == IsAction;
        //    set
        //    {
        //        mSelected = value;
        //    }
        //}

        #endregion
    }
}
