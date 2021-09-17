﻿using Microsoft.AspNetCore.Mvc;
using PeliculasAPI.Entidades;
using PeliculasAPI.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeliculasAPI.Controllers
{
    [Route("api/generos")]
    public class GenerosController: ControllerBase
    {

        public IRepositorio _repositorio;
        public GenerosController(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]   // api/generos
        [HttpGet("listado")]   // api/generos/listado
        [HttpGet("/listado")]   // /listado
        public ActionResult<List<Genero>> Get() {

            var generos = _repositorio.ObtenerTodosLosGeneros();

            return generos;
        }

        [HttpGet("{Id}")]   // api/generos/1
        public async Task<ActionResult<Genero>> Get(int Id)
        {

            var genero = await _repositorio.ObtenerGeneroPorId(Id);

            if (genero == null)
            {
                return NotFound();
            }

            //return Ok("Felipe");
            //return Ok(DateTime.Now);
            return genero;
        }

        [HttpGet("{Id:int}/{nombre=null}")]   // api/generos/1/oliver
        [HttpGet("GetGeneroPorId")]   // api/generos/GetGeneroPorId?id=1
        //public IActionResult Get(int Id, string nombre)        
        public async Task<ActionResult<Genero>> Get(int Id, string nombre)
        {

            var genero = await _repositorio.ObtenerGeneroPorId(Id);

            if (genero == null) {
                return NotFound();
            }

            //return Ok("Felipe");
            //return Ok(DateTime.Now);
            return genero;
        }

        [HttpPost]
        public ActionResult Post() {
            return NoContent();
        }
        
        [HttpPut]
        public ActionResult Put() {
            return NoContent();
        }
        [HttpDelete]
        public ActionResult Delete() {
            return NoContent();
        }

    }
}
