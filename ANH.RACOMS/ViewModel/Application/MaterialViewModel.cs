using ANH.Core;
using System;
using System.Windows.Input;
using static ANH.RACOMS.DI;

namespace ANH.RACOMS
{
    /// <summary>
    ///  The Settings state as a view model
    /// </summary>
    public class MaterialViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The Material Name
        /// </summary>
        public float Name { get; set; }

        /// <summary>
        /// The Material Linear Elastic information: Elastic modulus 11
        /// </summary>
        public float Elastic_Modulus_11 { get; set; }

        /// <summary>
        /// The Material Linear Elastic information: Elastic modulus 22
        /// </summary>
        public float Elastic_Modulus_22 { get; set; }

        /// <summary>
        /// The Material Linear Elastic information: Poisson Raito 12
        /// </summary>
        public float Poisson_Ration_12 { get; set; }

        /// <summary>
        /// The Material Linear Elastic information: Shear modulus 12
        /// </summary>
        public float Shear_Modulus_12 { get; set; }

        /// <summary>
        /// The Material Linear Elastic information: Thickness, tply
        /// </summary>
        public float Thickness_tply { get; set; }

        /// <summary>
        /// The Material Failure+In_Stress information: Tension Stress Limit 11
        /// </summary>
        public float Tension_Stress_Limit_11 { get; set; }

        /// <summary>
        /// The Material Failure+In_Stress information: Tension Stress Limit 22
        /// </summary>
        public float Tension_Stress_Limit_22 { get; set; }

        /// <summary>
        /// The Material Failure+In_Stress information: Compress Stress Limit 11
        /// </summary>
        public float Compress_Stress_Limit_11 { get; set; }

        /// <summary>
        /// The Material Failure+In_Stress information: Compress Stress Limit 11
        /// </summary>
        public float Compress_Stress_Limit_22 { get; set; }

        /// <summary>
        /// The Material Failure+In_Stress information: Shear Stress Limit 12
        /// </summary>
        public float Shear_Stress_Limit_12 { get; set; }

        /// <summary>
        /// The Material Failure+Out_Stress information: Tension Stress Limit 33
        /// </summary>
        public float Tension_Stress_Limit_33 { get; set; }

        /// <summary>
        /// The Material Failure+Out_Stress information: Tension Stress Limit 33
        /// </summary>
        public float Compress_Stress_Limit_33 { get; set; }

        /// <summary>
        /// The Material Failure+Out_Stress information: Inter-Laminate shear Stress Limit 13
        /// </summary>
        public float Interlaminate_Shear_Stress_Limit_13 { get; set; }

        /// <summary>
        /// The Material Failure+In_Strain information: Tension Strain Limit 11
        /// </summary>
        public float Tension_Strain_Limit_11 { get; set; }

        /// <summary>
        /// The Material Failure+In_Strain information: Tension Strain Limit 22
        /// </summary>
        public float Tension_Strain_Limit_22 { get; set; }

        /// <summary>
        /// The Material Failure+In_Strain information: Compress Strain Limit 11
        /// </summary>
        public float Compress_Strain_Limit_11 { get; set; }

        /// <summary>
        /// The Material Failure+In_Strain information: Compress Strain Limit 11
        /// </summary>
        public float Compress_Strain_Limit_22 { get; set; }

        /// <summary>
        /// The Material Failure+In_Strain information: Shear Strain Limit 12
        /// </summary>
        public float Shear_Strain_Limit_12 { get; set; }

        #endregion

        #region Public Commands

        /// <summary>
        /// The command to Open the settings menu
        /// </summary>
        public ICommand OpenCommand { get; set; }

        /// <summary>
        /// The command to close the settings menu
        /// </summary>
        public ICommand CloseCommand { get; set; }

        /// <summary>
        /// The command to logout of the application
        /// </summary>
        public ICommand LogoutCommand { get; set; }

        /// <summary>
        /// The command to clear the users data from the view model
        /// </summary>
        public ICommand ClearUserDataCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MaterialViewModel()
        {
            // Create commands
            OpenCommand = new RelayCommand(Open);
            CloseCommand = new RelayCommand(Close);
            LogoutCommand = new RelayCommand(Logout);
            ClearUserDataCommand = new RelayCommand(ClearUserData);

            //// TODO: Remove this with real infomation pulled from our database in future
            //Name = new TextEntryViewModel { Label = "Name", OriginalText = "Young-Min Lee" };
            //Username = new TextEntryViewModel { Label = "Username", OriginalText = "lee" };
            //Password = new PasswordEntryViewModel { Label = "Password", FakePassword = "********" };
            //Email = new TextEntryViewModel { Label = "Email", OriginalText = "youngmin.lee@anhstructure.com" };

            //// TODO: Get from localization
            //LogoutButtonText = "Logout";
        }

        #endregion

        /// <summary>
        /// Open the settings menu
        /// </summary>
        public void Open()
        {
            // Open settings menu
            ViewModelApplication.SettingsMenuVisible = true;
        }

        /// <summary>
        /// Closes the settings menu
        /// </summary>
        public void Close()
        {
            // Close settings menu
            ViewModelApplication.SettingsMenuVisible = false;
        }

        /// <summary>
        /// Logs the user out
        /// </summary>
        public void Logout()
        {
            // TODO: Confirm the user wants to logout

            // TODO: Clear any user data/cache

            // Clean all application level viewmodels that contain
            // any information about the current user
            ClearUserData();

            // Go to login page
            ViewModelApplication.GoToPage(ApplicationPage.Login);
        }

        /// <summary>
        /// Clears any data specific to the current user
        /// </summary>
        public void ClearUserData()
        {
            // Clear all view models containing the users info
            //Name = null;
            //Username = null;
            //Password = null;
            //Email = null;
        }
    }
}
