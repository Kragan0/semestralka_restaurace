﻿using UTB.Restauracia.Application.Abstraction;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace UTB.Restauracia.Application.Implementation
{
    public class FileUploadService : IFileUploadService
    {
        public string RootPath { get; set; }

        public FileUploadService(string rootPath)
        {
            this.RootPath = rootPath;
        }
        public string FileUpload(IFormFile fileToUpload, string folderNameOnServer)
        {
            string filePathOutput = String.Empty;

            var fileName = Path.GetFileNameWithoutExtension(fileToUpload.FileName);
            var fileExtension = Path.GetExtension(fileToUpload.FileName);
            var fileNameGenerated = Path.GetRandomFileName();
            string targetFolderPath = Path.Combine(this.RootPath, folderNameOnServer);
            

            var fileRelative = Path.Combine(folderNameOnServer, fileNameGenerated + fileExtension);
            var filePath = Path.Combine(this.RootPath, fileRelative);

            Directory.CreateDirectory(Path.Combine(this.RootPath, folderNameOnServer));
            using (Stream stream = new FileStream(filePath, FileMode.Create))
            {
                fileToUpload.CopyTo(stream);
            }
            filePathOutput = Path.DirectorySeparatorChar + fileRelative;

            return filePathOutput;
        }
    }
}
