using System;


namespace R5T.Argumentos.Default
{
    /// <summary>
    /// The default <see cref="ICommandLineArgumentsProvider"/> implementation.
    /// </summary>
    public class CommandLineArgumentsProvider : ICommandLineArgumentsProvider
    {
        public string[] GetCommandLineArguments()
        {
            var commandLineArguments = Environment.GetCommandLineArgs();
            return commandLineArguments;
        }
    }
}
