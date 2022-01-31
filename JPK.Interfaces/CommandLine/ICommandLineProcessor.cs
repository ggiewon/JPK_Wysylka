using System.Collections.Generic;

namespace JPK.Interfaces.CommandLine
{
    public interface ICommandLineProcessor
    {
        IEnumerable<string> GetCommandLineHelp();

        bool IsCommandLineArgumentsValid();

        string GetInputFilename();
    }
}