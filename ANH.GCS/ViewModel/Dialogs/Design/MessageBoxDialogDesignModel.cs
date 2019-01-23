﻿namespace ANH.GCS
{
    /// <summary>
    /// The design-time data for a <see cref="MessageBoxDialogViewModel"/>
    /// </summary>
    public class MessageBoxDialogDesignModel : MessageBoxDialogViewModel
    {

        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static MessageBoxDialogDesignModel Instance => new MessageBoxDialogDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MessageBoxDialogDesignModel()
        {
            Message = "Design time messages are fun :)";
            OkText = "OK";
        }

        #endregion
    }
}
