using System.Collections.Generic;

namespace ANH.GCS
{
    /// <summary>
    /// A view model for the overview analysis list
    /// </summary>
    public class AnalysisSubListViewModel : BaseViewModel
    {
        /// <summary>
        /// The analysis list items for the Side Menu
        /// </summary>
        public List<AnalysisSubListItemViewModel> Items { get; set; }

    }
}
