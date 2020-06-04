using System;
using System.IO;
using System.Threading.Tasks;

using R5T.Gloucester.Types;


namespace R5T.Kefalonia
{
    public interface IVisualStudioProjectFileStreamSerializer
    {
        /// <summary>
        /// Includes both <paramref name="stream"/> and <paramref name="projectFilePath"/> since project reference relative file paths will need to be made absolute.
        /// </summary>
        Task<ProjectFile> DeserializeAsync(Stream stream, string projectFilePath);

        /// <summary>
        /// Includes both <paramref name="stream"/> and <paramref name="projectFilePath"/> since project reference absolute file paths will need to be made relative.
        /// </summary>
        Task SerializeAsync(Stream stream, string projectFilePath, ProjectFile value);
    }
}
