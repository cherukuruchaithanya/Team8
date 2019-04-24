using Microsoft.Extensions.Logging;


namespace Team8
{
    /// <summary>

    /// </summary>
    public class ProgramLogger {
    private static ILoggerFactory _Factory = null;

    public static void ConfigureLogger (ILoggerFactory factory) {

           // factory.AddFile("Logs/mylog-{Date}.txt", isJson: true, minimumLevel: LogLevel.Debug);
        }

    public static ILoggerFactory LoggerFactory {
      get {
        if (_Factory == null) {
          _Factory = new LoggerFactory ();
          ConfigureLogger (_Factory);
        }
        return _Factory;
      }
      set { _Factory = value; }
    }
    public static ILogger CreateLogger () => LoggerFactory.CreateLogger ("APPLOG");
  }
}