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
        public ImageUploader(IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }

        public async Task<string> Uplaod(IFormFileCollection files, string folderName)
        {
            IFormFile image = files[0];

            string rootPath = _hostEnvironment.WebRootPath;
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
    }
}
