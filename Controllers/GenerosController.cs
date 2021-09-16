using Microsoft.AspNetCore.Mvc;
using PeliculasAPI.Entidades;
using PeliculasAPI.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.Controllers
{
    [Route("api/generos")]
    public class GenerosController
    {

        public IRepositorio _repositorio;
        public GenerosController(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]   // api/generos
        [HttpGet("listado")]   // api/generos/listado
        [HttpGet("/listado")]   // /listado
        public List<Genero> Get() {

            var generos = _repositorio.ObtenerTodosLosGeneros();

            return generos;
        }

        [HttpGet("{Id}")]   // api/generos/1
        [HttpGet("GetGeneroPorId")]   // api/generos/GetGeneroPorId?id=1
        public Genero Get(int Id)
        {

            var generos = _repositorio.ObtenerGeneroPorId(Id);
            return generos;
        }
        
        [HttpGet("{Id:int}/{nombre=null}")]   // api/generos/1/oliver
        public Genero Get(int Id, string nombre)
        {

            var generos = _repositorio.ObtenerGeneroPorId(Id);

            if (generos == null) {
                //return NotFound();
            }
            return generos;
        }

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
