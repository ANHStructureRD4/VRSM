using System.Collections.Generic;

namespace ANH.GCS
{
    /// <summary>
    /// The design-time data for a <see cref="AnalysisListViewModel"/>
    /// </summary>
    public class AnalysisListDesignModel : AnalysisListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static AnalysisListDesignModel Instance => new AnalysisListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public AnalysisListDesignModel()
        {
            Items = new List<AnalysisListItemViewModel>
            {
                new AnalysisListItemViewModel
                {
                    Initials = "Plain",
                    AnalysisName = "Plain Strength Analysis",
                    ProfilePictureRGB = "3099c5",
                    IconSource = "/Images/Icons/plain@2x.png",
                    Category = AnalysisCategory.PlainStrengthAnalysis,
                    LibraryItem = false,
                    IsSelect = true
                },
                new AnalysisListItemViewModel
                {
                    Initials = "Composite",
                    AnalysisName = "Composite Radius Analysis",
                    ProfilePictureRGB = "fe4503",
                    IconSource = "/Images/Icons/radius@2x.png",
                    Category = AnalysisCategory.CompositeRadiusAnalysis,
                    LibraryItem = false,
                    IsSelect = false
                },
                new AnalysisListItemViewModel
                {
                    Initials = "Sandwich",
                    AnalysisName = "Sandwich Panel Analysis",
                    ProfilePictureRGB = "00d405",
                    IconSource = "/Images/Icons/sandwich@2x.png",
                    Category = AnalysisCategory.SandwichPanelAnalysis,
                    LibraryItem = false,
                    IsSelect = false
                },
                new AnalysisListItemViewModel
                {
                    Initials = "Joint",
                    AnalysisName = "Joint Analysis",
                    ProfilePictureRGB = "ffa800",
                    IconSource = "/Images/Icons/joint@2x.png",
                    Category = AnalysisCategory.JointAnalysis,
                    LibraryItem = false,
                    IsSelect = false
                },
            };

            AnalysisDatas = new List<AnalysisListCategoryViewModel>
            {
                new AnalysisListCategoryViewModel
                {
                    Name = "Analysis Data",
                    CanExpand = true,
                    IsExpanded = true
                },
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
                new AnalysisListCategoryViewModel
                {
                    Name = "Analysis Execution",
                    CanExpand = true,
                    IsExpanded = true
                },
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
                ActionText = "Delete",
                IsAction = AnalysisAction.Delete
            };
        }

        #endregion
    }
}
