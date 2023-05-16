using HtmlAgilityPack;

namespace DatosNoticias;

public class MegaNoticias : IExtraccionEGuardadoNoticias
{
    public void ObtenerDatos(int cantidadPaginas, int tipo)
    {
        throw new NotImplementedException();
    }

    public void ExtraerDatos(HtmlDocument documentoHtml, HtmlWeb htmlWeb, ICollection<Noticia> listaNoticia, string categoria)
    {
        throw new NotImplementedException();
    }

    public void GuardarDatos(IEnumerable<Noticia> listaNoticia, string categoria)
    {
        throw new NotImplementedException();
    }
}