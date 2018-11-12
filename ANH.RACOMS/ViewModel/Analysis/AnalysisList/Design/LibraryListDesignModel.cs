using System.Collections.Generic;

namespace ANH.RACOMS
{
    /// <summary>
    /// The design-time data for a <see cref="AnalysisListViewModel"/>
    /// </summary>
    public class LibraryListDesignModel : AnalysisListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static LibraryListDesignModel Instance => new LibraryListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public LibraryListDesignModel()
        {
            Items = new List<AnalysisListItemViewModel>
            {
                new AnalysisListItemViewModel
                {
                    Initials = "Material",
                    AnalysisName = "Material System Library",
                    ProfilePictureRGB = "3099c5",
                    IconSource = "/Images/Icons/material@2x.png",
                    Category = AnalysisCategory.Materials,
                    LibraryItem = true,
                    IsSelect = true
                },
                new AnalysisListItemViewModel
                {
                    Initials = "Laminate",
                    AnalysisName = "Laminate System Library",
                    ProfilePictureRGB = "fe4503",
                    IconSource = "/Images/Icons/laminate@2x.png",
                    Category = AnalysisCategory.Laminate,
                    LibraryItem = true,
                    IsSelect = false
                },
                new AnalysisListItemViewModel
                {
                    Initials = "Fastener",
                    AnalysisName = "Fastener System Library",
                    ProfilePictureRGB = "00d405",
                    IconSource = "/Images/Icons/fastener@2x.png",
                    Category = AnalysisCategory.Fastener,
                    LibraryItem = true,
                    IsSelect = false
                }
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
