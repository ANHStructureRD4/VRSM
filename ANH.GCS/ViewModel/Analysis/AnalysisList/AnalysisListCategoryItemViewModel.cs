using System.Collections.Generic;

namespace ANH.GCS
{
    /// <summary>
    /// A view model for each analysis list item in the overview analysis list
    /// </summary>
    public class AnalysisListCategoryItemViewModel : BaseViewModel
    {
        #region public Properties
        
        /// <summary>
        /// The display name of Analysis list
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// True if this item is currently selected
        /// </summary>
        public bool IsSelected { get; set; }

        /// <summary>
        /// A list of all children contained inside this item
        /// </summary>
        public List<AnalysisSubListItemViewModel> AnalysisDetails { get; set; }

        /// <summary>
        /// Analysis Contents of Current item
        /// </summary>
        public AnalysisContent Content { get; set; }


        /// <summary>
        /// True if this item can expand or not
        /// </summary>
        public bool CanExpand { get; set; }

        #endregion
    }
}
