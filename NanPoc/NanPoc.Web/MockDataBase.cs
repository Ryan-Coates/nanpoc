using NanPoc.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanPoc.Web
{
    public class MockDataBase
    {
        static List<PostAdModel> posts = new List<PostAdModel>();

        public List<PostAdModel> GetPosts(SearchModel search)
        {
            List<PostAdModel> filteredList = posts;

            if(!string.IsNullOrEmpty(search.ItemType))
            {
                //filteredList = posts.Where(x=>x.)
            }

            return filteredList;
        }

        public void SavePost(PostAdModel post)
        {
            posts.Add(post);
        }
    }
}
