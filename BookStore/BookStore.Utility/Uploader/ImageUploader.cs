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

        public static string FileName { get; private set; }
        public static string FileExtension { get; private set; }
        public static string FileNameWithExtension { get; private set; }
        public static string FilePath { get; private set; }
        public static string FolderPath { get; private set; }
        public static string StreamPath { get; private set; }

        public async Task<string> Upload(IFormFileCollection files, string folderPath)
        {
            if (files.Count == 0)
                return null;

            IFormFile file = files[0];

            FileConfigurations(file, folderPath);
            await CreateCopyStreamAsync(file, StreamPath);

            return FilePath;
        }

        public void FileConfigurations(IFormFile file, string folderPath)
        {
            FolderPath = folderPath.TrimStart('\\');
            FileName = Guid.NewGuid().ToString();
            FileExtension = Path.GetExtension(file.FileName);
            FileNameWithExtension = FileName + FileExtension;
            StreamPath = Path.Combine(rootPath, FolderPath, FileNameWithExtension);
            FilePath = @"\" + Path.Combine(FolderPath, FileNameWithExtension);
        }

        public async Task CreateCopyStreamAsync(IFormFile file,string streamPath)
        {
            using var fileStream = new FileStream(streamPath, FileMode.Create);
            await file.CopyToAsync(fileStream);
            await fileStream.DisposeAsync();
        }

        public void Delete(string imageUrl)
        {
            File.Delete(imageUrl);           
        }

        public bool IsExist(string imageUrl)
        {
            if (imageUrl != null)
            {
                imageUrl = imageUrl.TrimStart('\\');
                string imgPath = Path.Combine(rootPath, imageUrl);
                if (File.Exists(imgPath))
                    return true;
            }

            return false;
        }

        public async Task<string> Update(IFormFileCollection files, string fileUrl, string folderPath)
        {
            if (files.Count > 0)
            {
                fileUrl = fileUrl.TrimStart('\\');
                string filePath = Path.Combine(rootPath, fileUrl);

                Delete(filePath);
                return await Upload(files, folderPath);
            }

            return null;
        }
    }
}
