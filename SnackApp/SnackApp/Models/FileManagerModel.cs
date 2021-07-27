using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace SnackApp.Models
{
    namespace SnackApp.Models
    {
        public class FileManagerModel
        {
            // prop
            public FileInfo[] Files { get; set; }

            // Archive 
            public IFormFile IFormFile { get; set; }

            // Archive list
            public List<IFormFile> IFormFiles { get; set; }

            // Save the folder name on the server which we are saving the archives
            public string PathImagesProduto { get; set; }
        }
    }
}