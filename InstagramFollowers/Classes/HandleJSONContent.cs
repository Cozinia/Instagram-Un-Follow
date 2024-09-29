using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace InstagramUnfollow.Classes
{
    public class HandleJSONContent
    {
        private List<RootStringListData> _listOfFolowers;
        private RelationshipsFollowing _listOfFolowings;

        public HandleJSONContent(string jsonContent)
        {
           if (jsonContent.Contains("relationships_following"))
           {
                //MessageBox.Show("Got here");
                _listOfFolowings = JsonConvert.DeserializeObject<RelationshipsFollowing>(jsonContent);

            }
           else
           {
                _listOfFolowers = JsonConvert.DeserializeObject<List<RootStringListData>>(jsonContent);
            }

        }

        public List<string> getFollowersList()
        {
            List<string> followers = new List<string>();
            foreach (var user in _listOfFolowers)
            {
               foreach (var userProperty in user.string_list_data)
                {
                    followers.Add(userProperty.value);
                }
            }
            return followers;
        }

        public List<string> getFollowingsList()
        {
            List<string> following = new List<string>();
            foreach (var user in _listOfFolowings.relationships_following) 
            {
                foreach (var item in user.string_list_data)
                {
                    following.Add(item.value);
                }
            }
            return following;
        }
    }
}
