using Microsoft.AspNetCore.Mvc;
using ObtenerSolucionesMicroservice.Domain;
using ObtenerSolucionesMicroservice.Entities.Filter;
using ObtenerSolucionesMicroservice.Entities.FilterValidator;
using ObtenerSolucionesMicroservice.Entities.Model;
using ObtenerSolucionesMicroservice.Exceptions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ObtenerSolucionesMicroservice.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ejemploController(ejemploDomain _domain) : ControllerBase
    {
        // GET: api/<ejemploController>
        [HttpGet]
        public async Task<IActionResult> Get()
            => Ok(await _domain.GetByList(null, ejemploFilterListType.ListItemejemplo, null));


        // GET api/<ejemploController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
            => Ok(await _domain.GetByItem(new ejemploFilter(id), ejemploFilterItemType.ByItemxID));

        // POST api/<ejemploController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ejemploCreateDto entidad)
        {
            // Crear instancia del validador específico para ejemploCreateDto
            var validator = new ejemploCreateDtoValidator();
            // Validar el modelo y obtener los errores
            FluentValidatorExceptions.ValidateModel(entidad, validator);
            return Ok(await _domain.Createejemplo(entidad));
        }

        // PUT api/<ejemploController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] ejemploUpdateDto value)
        {
            ejemploEntity ejemplo = new ejemploEntity()
            {
                //ID = id,
                //Edad = value.Edad,
                //Email = value.Email,
                //Nombre = value.Nombre
            };
            ejemploUpdateDtoValidator? validator = new ejemploUpdateDtoValidator();
            FluentValidatorExceptions.ValidateModel(ejemplo, validator);

            return Ok(await _domain.Editejemplo(ejemplo));
        }

        //// DELETE api/<ejemploController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
            => Ok(await _domain.Deleteejemplo(new ejemploEntity()
            {
                // ID = id 
            }));
    }
}
