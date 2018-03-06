using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanPoc.Web.Models
{
    public class DisplayModel
    {
        public List<PostAdModel> Posts { get; set; }
        public SearchModel Search { get; set; }
    }
}
