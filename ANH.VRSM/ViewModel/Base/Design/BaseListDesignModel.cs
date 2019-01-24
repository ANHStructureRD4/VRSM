using ANH.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ANH.VRSM.DI;

namespace ANH.VRSM
{
    /// <summary>
    /// The design-time data for a <see cref="BaseListViewModel"/>
    /// </summary>
    public class BaseListDesignModel : BaseListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static BaseListDesignModel Instance => new BaseListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseListDesignModel()
        {
            BaseList = BaseListItem.GetCompositeListsAsync().Result;

            

            //Items = new List<BaseListItemViewModel>
            //{
            //    new BaseListItemViewModel
            //    {
            //        Name = "Unit",
            //        Contents = AnalysisContent.Unit,
            //        IsSelected = true,
            //    },
            //    new BaseListItemViewModel
            //    {
            //        Name = "Geometry",
            //        Contents = AnalysisContent.Geometry,
            //        IsSelected = false,
            //    },
            //    new BaseListItemViewModel
            //    {
            //        Name = "Loads",
            //        Contents = AnalysisContent.Loads,
            //        IsSelected = false,
            //    },
            //    new BaseListItemViewModel
            //    {
            //        Name = "Analysis",
            //        Contents = AnalysisContent.parameter,
            //        IsSelected = false,
            //    },
            //    new BaseListItemViewModel
            //    {
            //        Name = "Results",
            //        Contents = AnalysisContent.Result,
            //        IsSelected = false,
            //    },
            //};
        }
        #endregion
    }
}
