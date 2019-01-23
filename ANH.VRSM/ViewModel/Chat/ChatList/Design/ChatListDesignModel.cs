using System.Collections.Generic;

namespace ANH.RACOMS
{
    /// <summary>
    /// The design-time data for a <see cref="ChatListViewModel"/>
    /// </summary>
    public class ChatListDesignModel : ChatListViewModel
    {
        #region Singleton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatListDesignModel Instance => new ChatListDesignModel();

        //public static ChatListDesignModel Instance { get { return new ChatListDesignModel(); } }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatListDesignModel()
        {

            //Items = new List<ChatListItemViewModel>();
            //var item = new ChatListItemViewModel();
            //item.Initials = "LM";
            //item.Name = "Luke";
            //item.Message = "This chat app is awesome! I bet it will be fast too";
            //item.ProfilePictureRGB = "3099c5";
            //Items.Add(item);

            Items = new List<ChatListItemViewModel>
            {
                new ChatListItemViewModel
                {
                    Initials = "LM",
                    Name = "Luke",
                    Message = "This chat app is awesome! I bet it will be fast too",
                    ProfilePictureRGB = "3099c5",
                    NewContentAvailable = true
                },
                new ChatListItemViewModel
                {
                    Initials = "JA",
                    Name = "Jess",
                    Message = "Hey dude, here are the new icons",
                    ProfilePictureRGB = "fe4503"
                },
                new ChatListItemViewModel
                {
                    Initials = "PL",
                    Name = "Parnell",
                    Message = "The new server is up, got 192.168.1.1",
                    ProfilePictureRGB = "00d405",
                    IsSelected = true
                },
                new ChatListItemViewModel
                {
                    Initials = "LM",
                    Name = "Luke",
                    Message = "This chat app is awesome! I bet it will be fast too",
                    ProfilePictureRGB = "3099c5"
                },
                new ChatListItemViewModel
                {
                    Initials = "JA",
                    Name = "Jess",
                    Message = "Hey dude, here are the new icons",
                    ProfilePictureRGB = "fe4503"
                },
                new ChatListItemViewModel
                {
                    Initials = "PL",
                    Name = "Parnell",
                    Message = "The new server is up, got 192.168.1.1",
                    ProfilePictureRGB = "00d405"
                },
                new ChatListItemViewModel
                {
                    Initials = "LM",
                    Name = "Luke",
                    Message = "This chat app is awesome! I bet it will be fast too",
                    ProfilePictureRGB = "3099c5"
                },
                new ChatListItemViewModel
                {
                    Initials = "JA",
                    Name = "Jess",
                    Message = "Hey dude, here are the new icons",
                    ProfilePictureRGB = "fe4503"
                },
                new ChatListItemViewModel
                {
                    Initials = "PL",
                    Name = "Parnell",
                    Message = "The new server is up, got 192.168.1.1",
                    ProfilePictureRGB = "00d405"
                },
                new ChatListItemViewModel
                {
                    Initials = "LM",
                    Name = "Luke",
                    Message = "This chat app is awesome! I bet it will be fast too",
                    ProfilePictureRGB = "3099c5"
                },
                new ChatListItemViewModel
                {
                    Initials = "JA",
                    Name = "Jess",
                    Message = "Hey dude, here are the new icons",
                    ProfilePictureRGB = "fe4503"
                },
                new ChatListItemViewModel
                {
                    Initials = "PL",
                    Name = "Parnell",
                    Message = "The new server is up, got 192.168.1.1",
                    ProfilePictureRGB = "00d405"
                },
            };
        }

        #endregion
    }
}
