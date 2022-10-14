using Portafolio.Models;
namespace Portafolio.Servicios
{

    public interface IRepositorioProyectos
    {
       public List<Proyecto> ObtenerProyecto();
    }
    public class RepositorioProyecto:IRepositorioProyectos
    {
        public  List<Proyecto> ObtenerProyecto()
        {
            var proyectos = new List<Proyecto>()
            {
                new Proyecto
                {
                    Titulo = "To Do App",
                    Descripcion = "To Do app realizado en ASP.NET CORE ",
                    Link="https://todo20221014081626.azurewebsites.net/",
                    ImagenURL="/imagenes/ToDo.png"
                },
                new Proyecto
                {
                    Titulo = "Manejo de presupuesto",
                    Descripcion = "Manejo de presupuesto app realizado en ASP.NET CORE ",
                    Link="https://manejopresupuesto20221014092335.azurewebsites.net/",
                    ImagenURL="/imagenes/ManejoPresupuesto.png"
                }
            };
            return proyectos;

        }

    }
}
