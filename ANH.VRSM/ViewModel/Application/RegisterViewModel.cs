using ANH.Core;
using System.Security;
using System.Threading.Tasks;
using System.Windows.Input;
using static ANH.VRSM.DI;

namespace ANH.VRSM
{
    /// <summary>
    /// The View Model for a login screen
    /// </summary>
    public class RegisterViewModel : BaseViewModel
    {

        #region Public Properties

        /// <summary>
        /// The email of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// A flag indicating if the register command is running
        /// </summary>
        public bool RegisterIsRunning { get; set; }

        #endregion

        #region Commands
        
        /// <summary>
        /// The command to login
        /// </summary>
        public ICommand LoginCommand { get; set; }

        /// <summary>
        /// The command to register for a new account
        /// </summary>
        public ICommand RegisterCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="window"></param>
        public RegisterViewModel()
        {
            // Create commands
            RegisterCommand = new RelayParameterizedCommand(async (parameter) => await RegisterAsync(parameter));
            LoginCommand = new RelayCommand(async () => await LoginAsync());

        }

        #endregion

        /// <summary>
        /// Attempts to register a new user
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the users password </param>
        /// <returns></returns>
        private async Task RegisterAsync(object parameter)
        {
            await RunCommandAsync(() => RegisterIsRunning, async () =>
            {
                await Task.Delay(5000);
            });

        }

        /// <summary>
        /// Takes the user to the login page 
        /// </summary>
        /// <returns></returns>
        private async Task LoginAsync()
        {
            //  Go to login page?
            ViewModelApplication.GoToPage(ApplicationPage.Login);

            //((WindowViewModel)((MainWindow)Application.Current.MainWindow).DataContext).CurrentPage = ApplicationPage.Register;

            await Task.Delay(1);
        }

    }
}
