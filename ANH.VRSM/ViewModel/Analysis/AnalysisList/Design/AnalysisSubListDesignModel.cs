using System.Collections.Generic;

namespace ANH.VRSM
{
    /// <summary>
    /// The design-time data for a <see cref="AnalysisSubListViewModel"/>
    /// </summary>
    public class AnalysisSubListDesignModel : AnalysisSubListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static AnalysisSubListDesignModel Instance => new AnalysisSubListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnalysisSubListDesignModel()
        {
            Items = new List<AnalysisSubListItemViewModel>
            {
                new AnalysisSubListItemViewModel
                {
                    Name = "Unit",
                    Contents = AnalysisContent.Unit,
                    IsSelected = true,
                },
                new AnalysisSubListItemViewModel
                {
                    Name = "Geometry",
                    Contents = AnalysisContent.Geometry,
                    IsSelected = false,
                },
                new AnalysisSubListItemViewModel
                {
                    Name = "Loads",
                    Contents = AnalysisContent.Loads,
                    IsSelected = false,
                },
                new AnalysisSubListItemViewModel
                {
                    Name = "Analysis",
                    Contents = AnalysisContent.parameter,
                    IsSelected = false,
                },
                new AnalysisSubListItemViewModel
                {
                    Name = "Results",
                    Contents = AnalysisContent.Result,
                    IsSelected = false,
                },
            };
        }

        #endregion
    }
}
