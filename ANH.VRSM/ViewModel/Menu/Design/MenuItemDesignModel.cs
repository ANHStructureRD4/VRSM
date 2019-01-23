using ANH.Core;

namespace ANH.RACOMS
{
    /// <summary>
    ///  The design-time data for a <see cref="MenuItemViewModel"/>
    /// </summary>
    public class MenuItemDesignModel : MenuItemViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static MenuItemDesignModel Instance => new MenuItemDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MenuItemDesignModel()
        {
            Text = "Hellow World";
            Icon = IconType.File;
        }

        #endregion
    }
}
