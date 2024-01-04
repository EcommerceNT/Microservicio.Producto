using Application.Interfaces.IService;
using Application.Request;
using Application.Response;
using Microsoft.AspNetCore.Mvc;

namespace Microservicio.Producto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        private readonly IColorService _service;

        public ColorController(IColorService service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(typeof(ColorResponse), 200)]
        public IActionResult GetColorList()
        {
            var result = _service.GetColorList();
            return new JsonResult(result);
        }

        [HttpPost]
        [ProducesResponseType(typeof(ColorResponse), 201)]
        [ProducesResponseType(typeof(Application.Request.BadRequest), 409)]
        public IActionResult CreateColor(ColorRequest request)
        {
            if (_service.ExisteColor(request.Descripcion))
            {
                return Conflict(new Application.Request.BadRequest
                {
                    Message = $"Ya existe un color con esa descripcion '{request.Descripcion}'."
                });
            }

            var result = _service.CreateColor(request);
            return new JsonResult(result) { StatusCode = 201 };
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ColorResponse), 200)]
        [ProducesResponseType(typeof(Application.Request.BadRequest), 404)]
        public IActionResult GetColorById(int id)
        {
            try
            {
                var result = _service.GetColorById(id);
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
        [ProducesResponseType(typeof(ColorResponse), 200)]
        [ProducesResponseType(typeof(Application.Request.BadRequest), 404)]
        [ProducesResponseType(typeof(Application.Request.BadRequest), 409)]
        public IActionResult UpdateColor(int id, ColorRequest request)
        {
            if (_service.ExisteColor(request.Descripcion))
            {
                return Conflict(new Application.Request.BadRequest
                {
                    Message = $"Ya existe un color con esa descripcion '{request.Descripcion}'."
                });
            }
            try
            {
                var result = _service.UpdateColor(id, request);
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
        [ProducesResponseType(typeof(ColorResponse), 200)]
        [ProducesResponseType(typeof(Application.Request.BadRequest), 404)]
        public IActionResult RemoveColor(int id)
        {
            try
            {
                var result = _service.RemoveColor(id);
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
