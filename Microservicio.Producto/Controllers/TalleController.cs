using Application.Interfaces.IService;
using Application.Request;
using Application.Response;
using Microsoft.AspNetCore.Mvc;

namespace Microservicio.Producto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TalleController : ControllerBase
    {
        private readonly ITalleService _service;

        public TalleController(ITalleService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(typeof(TalleResponse), 200)]
        public IActionResult GetTalleList()
        {
            var result = _service.GetTalleList();
            return new JsonResult(result);
        }

        [HttpPost]
        [ProducesResponseType(typeof(TalleResponse), 201)]
        [ProducesResponseType(typeof(Application.Request.BadRequest), 409)]
        public IActionResult CreateTalle(TalleRequest request)
        {
            if (_service.ExisteTalle(request.Descripcion))
            {
                return Conflict(new Application.Request.BadRequest
                {
                    Message = $"Ya existe un talle con esa descripcion '{request.Descripcion}'."
                });
            }

            var result = _service.CreateTalle(request);
            return new JsonResult(result) { StatusCode = 201 };
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(TalleResponse), 200)]
        [ProducesResponseType(typeof(Application.Request.BadRequest), 404)]
        public IActionResult GetTalleById(int id)
        {
            try
            {
                var result = _service.GetTalleById(id);
                return new JsonResult(result);
            }
            catch (Exception ex)
            {
                return NotFound(new Application.Request.BadRequest
                {
                    Message = ex.Message
                });
            }
        }

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(TalleResponse), 200)]
        [ProducesResponseType(typeof(Application.Request.BadRequest), 404)]
        [ProducesResponseType(typeof(Application.Request.BadRequest), 409)]
        public IActionResult UpdateTalle(int id, TalleRequest request)
        {
            if (_service.ExisteTalle(request.Descripcion))
            {
                return Conflict(new Application.Request.BadRequest
                {
                    Message = $"Ya existe un talle con esa descripcion '{request.Descripcion}'."
                });
            }
            try
            {
                var result = _service.UpdateTalle(id, request);
                return new JsonResult(result);
            }
            catch (ArgumentException ex)
            {
                return NotFound(new Application.Request.BadRequest
                {
                    Message = ex.Message
                });
            }
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(TalleResponse), 200)]
        [ProducesResponseType(typeof(Application.Request.BadRequest), 404)]
        public IActionResult RemoveTalle(int id)
        {
            try
            {
                var result = _service.RemoveTalle(id);
                return new JsonResult(result);
            }
            catch (ArgumentException ex)
            {
                return NotFound(new Application.Request.BadRequest
                {
                    Message = ex.Message
                });
            }
        }
    }
}
