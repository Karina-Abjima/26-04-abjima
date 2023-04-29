using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace _26_04.Controllers
{
    [Microsoft.AspNetCore.Components.Route("api/files")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        private readonly FileExtensionContentTypeProvider _fileExtensionContentTypeProvider;
        public FilesController(FileExtensionContentTypeProvider fileExtensionContentTypeProvider)
            {
            _fileExtensionContentTypeProvider = fileExtensionContentTypeProvider ??
                throw new System.ArgumentNullException(nameof(fileExtensionContentTypeProvider));
            }

        [HttpGet("{fileId}")]
        public ActionResult GetFile(string fileId)
        {//look up the actual file,depending on the fieldId 
            var PathToFile = "Networking-fundamentals.pdf";
            //check whether file exist
            if(!System.IO.File.Exists(PathToFile))
            { return NotFound(); }
            if (!_fileExtensionContentTypeProvider.TryGetContentType(PathToFile, out var contentType))
            {
                contentType = "application/octet-stream";
            }
            var bytes= System.IO.File.ReadAllBytes(PathToFile);
            return File(bytes,contentType,Path.GetFileName(PathToFile));
        }
    }
}
