using ANH.Core;
using static ANH.GCS.DI;

namespace ANH.GCS
{
    /// <summary>
    /// Locates view models from the IoC for use in binding in Xaml files
    /// </summary>
    public class ViewModelLocator
    {
        #region Public Properties

        /// <summary>
        /// Singleton instance of the locator
        /// </summary>
        public static ViewModelLocator Instance { get; private set; } = new ViewModelLocator();

        /// <summary>
        /// The application view model
        /// </summary>
        public static ApplicationViewModel ApplicationViewModel => ViewModelApplication;

        /// <summary>
        /// The settings view model
        /// </summary>
        public static SettingsViewModel SettingsViewModel => ViewModelSettings;

        /// <summary>
        /// The analysis view model
        /// </summary>
        public static AnalysisViewModel AnalysisViewModel => ViewModelAnalysis;

        #endregion

    }
}
