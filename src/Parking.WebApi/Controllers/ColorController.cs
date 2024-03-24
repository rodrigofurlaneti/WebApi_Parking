using Microsoft.AspNetCore.Mvc;
using Parking.Domain.Entities;
using Parking.Service.Service.Color;

namespace Parking.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ColorController : ControllerBase
    {
        private readonly ILogger<ColorController> _logger;
        private readonly IColorService _colorService;

        public ColorController(ILogger<ColorController> logger, IColorService colorService)
        {
            this._logger = logger;
            this._colorService = colorService;
        }

        [HttpGet(Name = "GetColor")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ColorEntity>))]
        public async Task<IActionResult> GetColor()
        {
            try
            {
                this._logger.LogInformation("WebApi_Color_GetAsync_Entry");
                var ret = await _colorService.GetAsync();
                this._logger.LogInformation("WebApi_Color_GetAsync_Exit");
                return Ok(ret);
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Color_GetAsync_Exception");
                string mensagem = "Erro ao consumir a controler Color, rota Get " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ColorEntity>))]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                this._logger.LogInformation("WebApi_Color_GetByIdAsync_Entry");
                var ret = await _colorService.GetByIdAsync(id);
                this._logger.LogInformation("WebApi_Color_GetByIdAsync_Entry");
                return Ok(ret);
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Color_GetAsync_Exception");
                string mensagem = "Erro ao consumir a controler Color, rota GetByIdAsync " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }
        }

        [HttpPost(Name = "InsertColor")]
        public async Task Post(ColorEntity entity)
        {
            try
            {
                this._logger.LogInformation("WebApi_Color_PostAsync_Entry");
                await _colorService.PostAsync(entity);
                this._logger.LogInformation("WebApi_Color_PostAsync_Exit");
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Color_PostAsync_Exception");
                string mensagem = "Erro ao consumir a controler Color, rota PostAsync " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }

        }

        [HttpPut(Name = "UpdateColor")]
        public async Task Put(ColorEntity entity)
        {
            try
            {
                this._logger.LogInformation("WebApi_Color_PutAsync_Entry");
                await _colorService.PutAsync(entity);
                this._logger.LogInformation("WebApi_Color_PutAsync_Exit");
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Color_PutAsync_Exception");
                string mensagem = "Erro ao consumir a controler Color, rota Put " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }

        }

        [HttpDelete("{id:int}")]
        public async Task Delete(int id)
        {
            try
            {
                this._logger.LogInformation("WebApi_Color_DeleteAsync_Entry");
                await _colorService.DeleteAsync(id);
                this._logger.LogInformation("WebApi_Color_DeleteAsync_Exit");
            }
            catch (Exception ex)
            {
                _logger.LogInformation("WebApi_Color_DeleteAsync_Exception");
                string mensagem = "Erro ao consumir a controler Color, rota DeleteAsync " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }
        }
    }
}