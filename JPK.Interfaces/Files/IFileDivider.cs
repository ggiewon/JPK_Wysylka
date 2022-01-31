using System.Collections.Generic;

namespace JPK.Interfaces.Files
{
    public interface IFileDivider
    {
        /// <summary>
        /// Method to divide file in to segments with provided size
        /// </summary>
        /// <param name="inputFilename"></param>
        /// <param name="segmentSize">Segment size in MB</param>
        /// <returns>Not null list of segments</returns>
        IList<string> Divide(string inputFilename, int segmentSize);
    }
}