using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace ERP.Defontana.Cpl.Util
{
    public static class ErrorUtils
    {
        private static Dictionary<string, string> mensajesDictionary;

        public static string ObtenerMensajeError(string msg)
        {

            if (mensajesDictionary == null)
            {
                mensajesDictionary = new Dictionary<string, string>();

                var resources = MensajesError.ResourceManager.GetResourceSet(CultureInfo.CurrentUICulture, true, true);

                foreach (DictionaryEntry entry in resources)
                {
                    mensajesDictionary.Add(entry.Key.ToString(), entry.Value.ToString());
                }

            }

            string mensaje = string.Empty;

            mensajesDictionary.TryGetValue(msg, out mensaje);

            return mensaje;
        }
    }
}
