using BlazorInputFile;
using System.IO;
using System.Threading.Tasks;

namespace Planner.Data.FileUpload
{
    /// <summary>
    /// FileUpload implementation.
    /// </summary>
    public class FileUpload : IFileUpload
    {
        /// <summary>
        /// Upload a file to the project dir.
        /// </summary>
        public async Task Upload(IFileListEntry file)
        {
            var path = Path.Combine($"{Directory.GetCurrentDirectory()}{@"\wwwroot\"}", "music", file.Name);

            var memoryStream = new MemoryStream();
            await file.Data.CopyToAsync(memoryStream);

            using FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
            memoryStream.WriteTo(fileStream);
        }

    }
}
