using SharpRaven;
using SharpRaven.Data;
using log4net;
using System;

namespace ERP.Defontana.Cpl.Util
{
    public static class Logger
    {
        private static readonly RavenClient RavenC;
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly bool SentryLoggerEnabled;
        private static readonly bool Log4NetLoggerEnabled;

        static Logger()
        {
            SentryLoggerEnabled = ConfigurationHelper.IsSentryLoggerEnabled();
            Log4NetLoggerEnabled = ConfigurationHelper.IsLog4NetLoggerEnabled();

            if (SentryLoggerEnabled)
            {
                RavenC = new RavenClient(ConfigurationHelper.GetConfigurationParameterResource("SentryDsn"));
            }
            if (Log4NetLoggerEnabled)
            {
                log4net.Config.XmlConfigurator.Configure();
            }
        }


        public static void Fatal(string msg)
        {
            if (SentryLoggerEnabled) RavenC.Capture(new SentryEvent(msg) { Level = ErrorLevel.Fatal });
            if (Log4NetLoggerEnabled) log.Fatal(msg);
        }

        public static void Fatal(Exception ex)
        {
            if (SentryLoggerEnabled) RavenC.Capture(new SentryEvent(ex) { Level = ErrorLevel.Fatal });
            if (Log4NetLoggerEnabled) log.Fatal(ex);
        }

        public static void Error(string msg)
        {
            if (SentryLoggerEnabled) RavenC.Capture(new SentryEvent(msg) { Level = ErrorLevel.Error });
            if (Log4NetLoggerEnabled) log.Error(msg);
        }

        public static void Error(string msg, Exception ex)
        {
            if (SentryLoggerEnabled) RavenC.Capture(new SentryEvent(ex) { Message = msg, Level = ErrorLevel.Error });
            if (Log4NetLoggerEnabled) log.Error(msg, ex);
        }

        public static void Error(Exception ex)
        {
            if (SentryLoggerEnabled) RavenC.Capture(new SentryEvent(ex) { Message = ex.Message, Level = ErrorLevel.Error });
            if (Log4NetLoggerEnabled) log.Error(ex);
        }

        public static void Info(string msg)
        {
            if (SentryLoggerEnabled) RavenC.Capture(new SentryEvent(msg) { Level = ErrorLevel.Info });
            if (Log4NetLoggerEnabled) log.Info(msg);
        }

        public static void Info(Exception ex)
        {
            if (SentryLoggerEnabled) RavenC.Capture(new SentryEvent(ex) { Level = ErrorLevel.Info });
            if (Log4NetLoggerEnabled) log.Info(ex);
        }

        public static void Info(string msg, Exception ex)
        {
            if (SentryLoggerEnabled) RavenC.Capture(new SentryEvent(msg + " " + ex.Message) { Level = ErrorLevel.Info });
            if (Log4NetLoggerEnabled) log.Info(msg + " " + ex.Message);
        }


        #region Log con Sesion

        //public static void Fatal(Exception ex, SesionOne sesionOne)
        //{
        //    if (LoggerEnabled) RavenC.CaptureException(ex, ex.Message, ErrorLevel.Fatal, ConvertirSesionDictionary(sesionOne));
        //}

        //public static void Fatal(string msg, SesionOne sesionOne)
        //{
        //    if (LoggerEnabled) RavenC.CaptureMessage(msg, ErrorLevel.Fatal, ConvertirSesionDictionary(sesionOne));
        //}

        //public static void Error(string msg, SesionOne sesionOne)
        //{
        //    if (LoggerEnabled) RavenC.CaptureMessage(msg, ErrorLevel.Error, ConvertirSesionDictionary(sesionOne));
        //}

        //public static void Error(Exception ex, SesionOne sesionOne)
        //{
        //    if (LoggerEnabled) RavenC.CaptureException(ex, ex.Message, ErrorLevel.Error, ConvertirSesionDictionary(sesionOne));
        //}

        //public static void Info(string msg, SesionOne sesionOne)
        //{
        //    if (LoggerEnabled) RavenC.CaptureMessage(msg, ErrorLevel.Info, ConvertirSesionDictionary(sesionOne));
        //}

        //public static void Info(object msg, Exception ex, SesionOne sesionOne)
        //{
        //    if (LoggerEnabled) RavenC.CaptureMessage(msg + " " + ex.Message, ErrorLevel.Info, ConvertirSesionDictionary(sesionOne));
        //}


        //TODO: utilizar esta implementacion cuando creemos un session para UXGEN
        //private static Dictionary<string, string> ConvertirSesionDictionary(SesionOne sesion)
        //{
        //    if (sesion == null) return null;
        //    var sesionDicc = new Dictionary<string, string>
        //    {
        //        {"IdCliente", sesion.IdCliente},
        //        {"IdEmpresa", sesion.IdEmpresa},
        //        {"IdUsuario", sesion.IdCliente + "-" + sesion.IdUsuario},
        //        {"IdSesion", sesion.IdSesion.ToString()}
        //    };

        //    if (sesion.SesionJump != null) { sesionDicc.Add("Correo", sesion.SesionJump.Correo); }

        //    return sesionDicc;
        //}

        #endregion        

    }
}
