﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;



namespace FacebookLogic
{
    public class FetchLogic : FacebookLogicManagment
    {
        public static string getProfilePicture()
        {
            return loggedInUser.PictureLargeURL;
        }

        public static string getUserName()
        {
            return loggedInUser.Name;
        }

        public static List<String> getUserPosts()
        {
            List<String> userPostsList = new List<String>();

            foreach (Post post in loggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    userPostsList.Add(post.Message);
                }
            }

            return userPostsList;
        }

        public static List<String> getAlbumsNames()
        {
            List<String> userAlbumsList = new List<String>();

            foreach (Album album in loggedInUser.Albums)
            {
                userAlbumsList.Add(album.Name);
            }

            return userAlbumsList;
        }

        public static string getSelectedAlbumPicture(string i_albumName)
        {
            string albumPictureSource = null;

            foreach (Album album in loggedInUser.Albums)
            {
                if (album.Name == i_albumName)
                {
                    albumPictureSource = album.PictureAlbumURL;
                }
            }
            return albumPictureSource;
        }
    }
}
