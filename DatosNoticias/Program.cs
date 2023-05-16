using System.Text;
using DatosNoticias;
using DatosNoticias.Elastic;
using Elasticsearch.Net;
using Nest;

/*
//var theClinic = new TheClinic();
//theClinic.ObtenerDatos(40,2);
//theClinic.ObtenerDatos(177,3);

var cnnChile = new CnnChile();
//cnnChile.ObtenerDatos(305,1);
//cnnChile.ObtenerDatos(500,2);
//cnnChile.ObtenerDatos(142,3);

var mercurio = new Mercurio();

//mercurio.ObtenerDatos(500,1);
//mercurio.ObtenerDatos(234,2);
//mercurio.ObtenerDatos(144,3);

var megaNoticias = new MegaNoticias);*/

//ElasticSearch.CrearIndice("pruebas-varios");
//IndexarNoticias.Indexar();
//ElasticSearch.BusquedaCoincidenciaExacta("pruebas-varios","crecimiento");
ElasticSearch.BusquedaCoincidenciaDifusa("pruebas-varios","actividad educativa y el congreso");