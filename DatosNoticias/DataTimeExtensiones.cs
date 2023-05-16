using System.Globalization;

namespace DatosNoticias;

public static class DataTimeExtensiones
{
    public static string NormalizarFecha(this string fecha)
    {
        var dateTime = DateTime.ParseExact(fecha, "ddd MMM dd yyyy HH:mm:ss 'GMT'zzz", CultureInfo.InvariantCulture);
        return dateTime.ToString("dd.MM.yyyy");
    }
}