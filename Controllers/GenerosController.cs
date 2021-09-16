using Microsoft.AspNetCore.Mvc;
using PeliculasAPI.Entidades;
using PeliculasAPI.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.Controllers
{
    [Route("api/genero")]
    public class GenerosController
    {
        public IRepositorio _repositorio;
        public GenerosController(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public List<Genero> Get() {

            var generos = _repositorio.ObtenerTodosLosGeneros();

            return generos;
        }
        
        //[HttpGet]
        //public Genero Get(int Id) {

        //    var generos = _repositorio.ObtenerGeneroPorId(Id);
        //    return generos;
        //}

        [HttpPost]
        public void Post() { 
        
        }
        
        [HttpPut]
        public void Put() { 
        
        }
        [HttpDelete]
        public void Delete() { 
        
        }

    }
}
