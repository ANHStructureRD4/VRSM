using ANH.Database;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using static ANH.VRSM.DI;

namespace ANH.VRSM
{
    /// <summary>
    /// A view model for the overview analysis list
    /// </summary>
    public class SignUpPageViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// The analysis list items for the Sign Up page
        /// </summary>
        public List<SignUpPageItemViewModel> Items { get; set; }


        public List<CompositeDataModel> SignUpPage{ get; set; }

        #endregion

        #region Constructor

        public SignUpPageViewModel()
        {
        }

        #endregion

    }
}
