using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Facade
{
    public class User
    {
        private List<User> Followers = new List<User>();

        public string UserName { get; set; }

        public bool Follow(User userToFollow)
        {
            //code for adding you as a follower
            return true;
        }

        public bool FollowerAdded(User newFollower)
        {
            //code for notification user that they have as added follower
            Notification notification = new Notification();
            return notification.NotifyUser(this, newFollower.UserName + " is now following you!");
        }

        public bool FollowingTextPost(User userToFollow)
        {
            // code for posting simple text
            Post post = new Post();
            return post.PostText(this, this.UserName + " is now following " + userToFollow.UserName);
        }

        public bool notifyFollowers(User userToFollow)
        {
            bool result = true;
            Notification notification = new Notification();
            foreach (User follower in Followers)
            {
                // code for notifying followers of new activity
                result = notification.NotifyUser(this, this.UserName + " is now following " + userToFollow);
                if(!result)
                {
                    break;
                }
            }
            return result;
        }
    }
}
