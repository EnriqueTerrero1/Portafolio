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
                    Link="",
                    ImagenURL="/imagenes/amazon.png"
                },
                new Proyecto
                {
                    Titulo = "Rent Car App",
                    Descripcion = "Rent Car app realizado en ASP.NET CORE ",
                    Link="",
                    ImagenURL="/imagenes/amazon.png"
                }
            };
            return proyectos;

        }

    }
}
