using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace My_Final_Project_Staffy.Utilities
{
    public static class FileUtilities
    {
        public static async Task<string> FileCreate(this IFormFile file,string root,string folder)
        {
            string fileName = Guid.NewGuid()+file.FileName;
            string path = Path.Combine(root,"assets","images");
            string fullPath = Path.Combine(path, fileName);
            using (FileStream stream = new FileStream(fullPath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return fileName;    
        }
    }
}
