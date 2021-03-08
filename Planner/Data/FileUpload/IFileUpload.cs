using BlazorInputFile;
using System.Threading.Tasks;

namespace Planner.Data.FileUpload
{
    /// <summary>
    /// FileUpload interface.
    /// </summary>
    public interface IFileUpload
    {
        /// <summary>
        /// Upload a file to the project dir.
        /// </summary>
        Task Upload(IFileListEntry file);
    }
}
