using Portafolio.Models;

namespace Portafolio.Servicios
{

    //Interface
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }
    public class RepositorioProyectos : IRepositorioProyectos
    {

    public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
                new Proyecto
            {
                Titulo="Crud .NET 6 MVC",
                Descripcion="Crud realizado con .NET Y C#",
                Link="https://github.com/DIEGOMARCE/CRUD-MVC-.NET-6",
                ImagenURL="/imagenes/crud.net.png"
            },

                 new Proyecto
            {
                Titulo="Api Rest",
                Descripcion="Consumiendo api de rick and morty",
                Link="https://github.com/DIEGOMARCE/FrontApiRickAndMorty",
                ImagenURL="/imagenes/api_rick.png"
            },
                  new Proyecto
            {
                Titulo="To do List Javascript",
                Descripcion="Aplicacion de tareas realizada con Javascript",
                Link="https://github.com/DIEGOMARCE/TodoListJavaScript",
                ImagenURL="/imagenes/todolist.png"
            },
                   new Proyecto
            {
                Titulo="Aplicacion de tareas React",
                Descripcion="Realizada con React usando useState,UseEffect y localStorage",
                Link="https://github.com/DIEGOMARCE/-React-Aplicacion-de-tareas-con-useState-useEffect-y-localStorage",
                ImagenURL="/imagenes/react.png"
            },


             };

        }

    }
}
