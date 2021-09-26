using PeliculasAPI.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.Repositorios
{
    public class RepositorioEnMemoria: IRepositorio
    {
        public List<Genero> _generos;
        public Guid _guid;
        public RepositorioEnMemoria()
        {
            _generos = new List<Genero>{
                new Genero(){ Id= 1, Nombre= "Accion"},
                new Genero(){ Id= 2, Nombre= "Comedia"},
            };
            _guid = Guid.NewGuid(); //123456-DMASkJ-55KKQKOPOT-QLFKF2
        }

        public List<Genero> ObtenerTodosLosGeneros() {

            return _generos;
        }

        public async Task<Genero> ObtenerGeneroPorId(int Id) {

            await Task.Delay(TimeSpan.FromSeconds(1));

            return _generos.FirstOrDefault(x => x.Id == Id);
        }

        public Guid ObtenerGuid()
        {
            return _guid;
        }

        public void CrearGenero(Genero genero)
        {
            genero.Id = _generos.Count() + 1;
            _generos.Add(genero);
        }
    }
}
