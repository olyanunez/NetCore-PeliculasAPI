using PeliculasAPI.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeliculasAPI.Repositorios
{
    public interface IRepositorio
    {
        Task<Genero> ObtenerGeneroPorId(int Id);
        List<Genero> ObtenerTodosLosGeneros();
    }
}