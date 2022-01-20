using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Utility.Uploader
{
    public class ImageUploader
    {
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly string rootPath;
        public ImageUploader(IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
            rootPath = _hostEnvironment.WebRootPath;
        }

        public async Task<string> Upload(IFormFileCollection files, string folderName)
        {
            IFormFile image = files[0];
            string imageName = Guid.NewGuid().ToString();
            string imageExtension = Path.GetExtension(image.FileName);

            folderName = folderName.TrimStart('\\');
            string streamPath = Path.Combine(rootPath, folderName, imageName + imageExtension);

            using var fileStream = new FileStream(streamPath, FileMode.Create);
            await image.CopyToAsync(fileStream);
            await fileStream.DisposeAsync();

            string imagePath = @"\" + Path.Combine(folderName, imageName + imageExtension);
            return imagePath;
        }

        public void Delete(string previousImgUrl)
        {
            if (previousImgUrl != null)
            {
                previousImgUrl = previousImgUrl.TrimStart('\\');
                string imgPath = Path.Combine(rootPath, previousImgUrl);
                if (File.Exists(imgPath))                
                    File.Delete(imgPath);                
            }
        } 
    }
}
