using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PeliculasAPI.Entidades;
using PeliculasAPI.Filtros;
using PeliculasAPI.Repositorios;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PeliculasAPI.Controllers
{
    [Route("api/generos")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class Generos_EjemplosController: ControllerBase
    {

        private readonly IRepositorio _repositorio;
        private readonly WeatherForecastController weatherForecastController;
        private readonly ILogger<Generos_EjemplosController> logger;

        public Generos_EjemplosController(IRepositorio repositorio, WeatherForecastController weatherForecastController, ILogger<Generos_EjemplosController> logger)
        {
            this._repositorio = repositorio;
            this.weatherForecastController = weatherForecastController;
            this.logger = logger;
        }

        //[HttpGet]               // api/generos
        //[HttpGet("listado")]    // api/generos/listado
        //[HttpGet("/listado")]   // /listado
        ////[ResponseCache(Duration = 60)]
        //[ServiceFilter(typeof(MiFiltroDeAccion))]
        //public ActionResult<List<Genero>> Get() 
        //{

        //    logger.LogInformation("Vamos a mostrar los generos");

        //    var generos = _repositorio.ObtenerTodosLosGeneros();

        //    return generos;
        //}
        
        //[HttpGet("guid")] // api/generos/guid
        //public ActionResult<Guid> GetGuid() {


        //    return Ok(new 
        //            {
        //                Guid_Generos_EjemplosController = _repositorio.ObtenerGuid(),
        //                Guid_WeatherForecastController = weatherForecastController.ObtenerGUIDWeatherForecastController()
        //            });
        //}

        ////[HttpGet("{Id}")]   // api/generos/1
        ////[HttpGet("{Id:int}/{nombre=null}")]   // api/generos/1/oliver
        //[HttpGet("{Id:int}")]                   // api/generos/1
        //[HttpGet("GetGeneroPorId")]             // api/generos/GetGeneroPorId?id=1
        ////public IActionResult Get(int Id, string nombre)        
        //public async Task<ActionResult<Genero>> Get(int Id, [FromHeader]string nombre)
        //{
        //    //if (!ModelState.IsValid) {
        //    //    return BadRequest(ModelState);
        //    //}

        //    //logger.LogDebug($"Obteniendo un genero por id {Id}");

        //    var genero = await _repositorio.ObtenerGeneroPorId(Id);

        //    if (genero == null) {

        //        throw new ApplicationException($"El genero de ID {Id} no fue encontrado");

        //        //logger.LogWarning($"No pudimos encontrar el genero de id {Id}");
        //    }

        //    //return Ok("Felipe");
        //    //return Ok(DateTime.Now);
        //    return genero;
        //}

        //[HttpPost]
        //public ActionResult Post([FromBody] Genero genero) 
        //{
        //    //if (!ModelState.IsValid)
        //    //{
        //    //    return BadRequest(ModelState);
        //    //}

        //    _repositorio.CrearGenero(genero);
        //    return NoContent();
        //}
        
        //[HttpPut]
        //public ActionResult Put([FromBody] Genero genero)
        //{
        //    //if (!ModelState.IsValid)
        //    //{
        //    //    return BadRequest(ModelState);
        //    //}
        //    return NoContent();
        //}
        //[HttpDelete]
        //public ActionResult Delete() {
        //    return NoContent();
        //}

    }
}
