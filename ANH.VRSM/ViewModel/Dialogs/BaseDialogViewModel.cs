//using PropertyChanged;
using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ANH.RACOMS
{
    /// <summary>
    /// A base view model for any dialogs
    /// </summary>
    //[ImplementPropertyChanged] // no more used
    public class BaseDialogViewModel : BaseViewModel
    {
        /// <summary>
        /// The title of the message box
        /// </summary>
        public string Title { get; set; }

    }
}
