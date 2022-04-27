using System;using R5T.T0064;


namespace R5T.Argumentos.Default
{[ServiceImplementationMarker]
    /// <summary>
    /// The default <see cref="ICommandLineArgumentsProvider"/> implementation.
    /// </summary>
    public class CommandLineArgumentsProvider : ICommandLineArgumentsProvider,IServiceImplementation
    {
        public string[] GetCommandLineArguments()
        {
            var commandLineArguments = Environment.GetCommandLineArgs();
            return commandLineArguments;
        }
    }
}
