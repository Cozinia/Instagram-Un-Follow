using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramUnfollow.Classes
{
    public class RootStringListData
    {
        public string title { get; set; }
        public List<MediaListData> media_list_data { get; set; }
        public List<StringListData> string_list_data { get; set; }
    }
}
