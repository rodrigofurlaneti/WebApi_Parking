using Microsoft.AspNetCore.Mvc;
using Parking.Domain.Entities;
using Parking.Service.Service.Type;

namespace Parking.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TypeController : ControllerBase
    {
        private readonly ILogger<TypeController> _logger;
        private readonly ITypeService _typeService;

        public TypeController(ILogger<TypeController> logger, ITypeService typeService)
        {
            this._logger = logger;
            this._typeService = typeService;
        }

        [HttpGet(Name = "GetType")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<TypeEntity>))]
        public async Task<IActionResult> GetType()
        {
            try
            {
                this._logger.LogInformation("WebApi_Type_GetAsync_Entry");
                var ret = await _typeService.GetAsync();
                this._logger.LogInformation("WebApi_Type_GetAsync_Exit");
                return Ok(ret);
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Type_GetAsync_Exception");
                string mensagem = "Erro ao consumir a controler Type, rota Get " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<TypeEntity>))]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                this._logger.LogInformation("WebApi_Type_GetByIdAsync_Entry");
                var ret = await _typeService.GetByIdAsync(id);
                this._logger.LogInformation("WebApi_Type_GetByIdAsync_Entry");
                return Ok(ret);
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Type_GetAsync_Exception");
                string mensagem = "Erro ao consumir a controler Type, rota GetByIdAsync " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }
        }

        [HttpPost(Name = "InsertType")]
        public async Task Post(TypeEntity entity)
        {
            try
            {
                this._logger.LogInformation("WebApi_Type_PostAsync_Entry");
                await _typeService.PostAsync(entity);
                this._logger.LogInformation("WebApi_Type_PostAsync_Exit");
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Type_PostAsync_Exception");
                string mensagem = "Erro ao consumir a controler Type, rota PostAsync " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }

        }

        [HttpPut(Name = "UpdateType")]
        public async Task Put(TypeEntity entity)
        {
            try
            {
                this._logger.LogInformation("WebApi_Type_PutAsync_Entry");
                await _typeService.PutAsync(entity);
                this._logger.LogInformation("WebApi_Type_PutAsync_Exit");
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Type_PutAsync_Exception");
                string mensagem = "Erro ao consumir a controler Type, rota Put " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }

        }

        [HttpDelete("{id:int}")]
        public async Task Delete(int id)
        {
            try
            {
                this._logger.LogInformation("WebApi_Type_DeleteAsync_Entry");
                await _typeService.DeleteAsync(id);
                this._logger.LogInformation("WebApi_Type_DeleteAsync_Exit");
            }
            catch (Exception ex)
            {
                _logger.LogInformation("WebApi_Type_DeleteAsync_Exception");
                string mensagem = "Erro ao consumir a controler Type, rota DeleteAsync " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }
        }
    }
}