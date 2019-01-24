using Dna;
using ANH.Core;
using ANH.Database;

namespace ANH.VRSM
{
    /// <summary>
    /// A shorthand access class to get DI services with nice clean short code
    /// </summary>
    public static class DI
    {
        /// <summary>
        /// A shortcut to access the <see cref="IUIManager"/>
        /// </summary>
        public static IUIManager UI => Framework.Service<IUIManager>();

        /// <summary>
        /// A shortcut to access the <see cref="ApplicationViewModel"/>
        /// </summary>
        public static ApplicationViewModel ViewModelApplication => Framework.Service<ApplicationViewModel>();

        /// <summary>
        /// A shortcut to access the <see cref="SettingsViewModel"/>
        /// </summary>
        public static SettingsViewModel ViewModelSettings => Framework.Service<SettingsViewModel>();

        /// <summary>
        /// A shortcut to access the <see cref="AnalysisViewModel"/>
        /// </summary>
        public static AnalysisViewModel ViewModelAnalysis => Framework.Service<AnalysisViewModel>();

        /// <summary>
        /// A shortcut to access toe <see cref="IClientDataStore"/> service
        /// </summary>
        public static IClientDataStore ClientDataStore => Framework.Service<IClientDataStore>();

        /// <summary>
        /// A shortcut to access toe <see cref="IBaseListDataStore"/> service
        /// </summary>
        public static IBaseListDataStore BaseListItem => Framework.Service<IBaseListDataStore>();

        /// <summary>
        /// A shortcut to access toe <see cref="IMaterialListDataStore"/> service
        /// </summary>
        public static IMaterialListDataStore MaterialListItem => Framework.Service<IMaterialListDataStore>();
    }
}
