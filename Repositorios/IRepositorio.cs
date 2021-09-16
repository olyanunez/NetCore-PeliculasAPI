﻿using PeliculasAPI.Entidades;
using System.Collections.Generic;

namespace PeliculasAPI.Repositorios
{
    public interface IRepositorio
    {
        Genero ObtenerGeneroPorId(int Id);
        List<Genero> ObtenerTodosLosGeneros();
    }
}