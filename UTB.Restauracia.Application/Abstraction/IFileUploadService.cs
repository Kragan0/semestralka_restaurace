using Microsoft.AspNetCore.Http;

namespace UTB.Restauracia.Application.Abstraction
{
    public interface IFileUploadService
    {
        string FileUpload(IFormFile fileToUpload, string folderNameOfServer);
    }
}
