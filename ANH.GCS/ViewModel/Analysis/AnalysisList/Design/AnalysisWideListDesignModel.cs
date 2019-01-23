using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ANH.GCS
{
    /// <summary>
    /// The design-time data for a <see cref="AnalysisWideListViewModel"/>
    /// </summary>
    public class AnalysisWideListDesignModel : AnalysisWideListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static AnalysisWideListDesignModel Instance => new AnalysisWideListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnalysisWideListDesignModel()
        {
            AnalysisDatas = new List<AnalysisListCategoryViewModel>
            {
                new AnalysisListCategoryViewModel
                {
                    Name = "Plain Analysis 01",
                    CanExpand = false,
                    IsExpanded = false
                },
                new AnalysisListCategoryViewModel
                {
                    Name = "Plain Analysis 02",
                    CanExpand = false,
                    IsExpanded = false
                },
                new AnalysisListCategoryViewModel
                {
                    Name = "Plain Analysis 03",
                    CanExpand = false,
                    IsExpanded = false
                },
            };

            AnalysisExecutions = new List<AnalysisListCategoryViewModel>
            {
                new AnalysisListCategoryViewModel
                {
                    Name = "Analysis Parameter",
                    CanExpand = false,
                    IsExpanded = false
                },
                new AnalysisListCategoryViewModel
                {
                    Name = "Analysis Result",
                    CanExpand = false,
                    IsExpanded = false
                },
            };

            Create = new IConActionViewModel
            {
                IconSource = "/Images/Icons/creat_.png",
                IconHoverSource = "/Images/Icons/creat.png",
                IconSelectSource = "/Images/Icons/creat_select.png",
                ActionText = "Create",
                IsAction = AnalysisAction.Create
            };

            Import = new IConActionViewModel
            {
                IconSource = "/Images/Icons/import_.png",
                IconHoverSource = "/Images/Icons/import.png",
                IconSelectSource = "/Images/Icons/import_select.png",
                ActionText = "Import",
                IsAction = AnalysisAction.Import
            };

            Modify = new IConActionViewModel
            {
                IconSource = "/Images/Icons/modify_.png",
                IconHoverSource = "/Images/Icons/modify.png",
                IconSelectSource = "/Images/Icons/modify_select.png",
                ActionText = "Modify",
                IsAction = AnalysisAction.Modify
            };

            Delete = new IConActionViewModel
            {
                IconSource = "/Images/Icons/delete_.png",
                IconHoverSource = "/Images/Icons/delete.png",
                IconSelectSource = "/Images/Icons/delete_select.png",
                ActionText = "Modify",
                IsAction = AnalysisAction.Delete
            };

        }

        #endregion
    }
}
