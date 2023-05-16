using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace DatosNoticias.Elastic;

public static class IndexarNoticias
{
    public static void Indexar()
    {
        using var escribir =
            new StreamReader(
                $"C:/Users/hello/RiderProjects/DatosNoticias/DatosNoticias/LaTercera/la_tercera_politica.csv");
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = "   ",
            HasHeaderRecord = true
        };
        using var leerCsv = new CsvReader(escribir, config);
        var options = new TypeConverterOptions { Formats = new[] { "dd.MM.yyyy" } };
        leerCsv.Context.TypeConverterOptionsCache.AddOptions<DateTime>(options);
        var noticias = leerCsv.GetRecords<MappingNoticia>().ToList();
        ElasticSearch.AgregarVariosDocumentos("pruebas-varios", noticias);
    }
}