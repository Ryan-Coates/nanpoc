using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NanPoc.Web.Models
{
    public class PostAdModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public IFormFile Image { get; set; }
        public string ImageURL { get; set; }

        public void SetImageURL()
        {         
            if (Image.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    Image.CopyTo(ms);
                    var fileBytes = ms.ToArray();
                    string imageBase64Data = Convert.ToBase64String(fileBytes);
                    // act on the Base64 data
                    string imageDataURL = string.Format("data:image/png;base64,{0}", imageBase64Data);
                    ImageURL = imageDataURL;
                }
            }
            throw new InvalidOperationException("file is empty");
            
            
        }
    }
}
