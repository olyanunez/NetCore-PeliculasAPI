using PeliculasAPI.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeliculasAPI.Repositorios
{
    public interface IRepositorio
    {
        void CrearGenero(Genero genero);
        Task<Genero> ObtenerGeneroPorId(int Id);
        Guid ObtenerGuid();
        List<Genero> ObtenerTodosLosGeneros();
    }
}