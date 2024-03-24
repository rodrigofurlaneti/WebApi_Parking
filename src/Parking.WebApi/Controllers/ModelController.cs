using Microsoft.AspNetCore.Mvc;
using Parking.Domain.Entities;
using Parking.Service.Service;
using Parking.Service.Service.Model;

namespace Parking.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ModelController : ControllerBase
    {
        private readonly ILogger<ModelController> _logger;
        private readonly IModelService _modelService;

        public ModelController(ILogger<ModelController> logger, IModelService modelService)
        {
            this._logger = logger;
            this._modelService = modelService;
        }

        [HttpGet(Name = "GetModel")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ModelEntity>))]
        public async Task<IActionResult> GetModel()
        {
            try
            {
                this._logger.LogInformation("WebApi_Model_GetAsync_Entry");
                var ret = await _modelService.GetAsync();
                this._logger.LogInformation("WebApi_Model_GetAsync_Exit");
                return Ok(ret);
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Model_GetAsync_Exception");
                string mensagem = "Erro ao consumir a controler Model, rota Get " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ModelEntity>))]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                this._logger.LogInformation("WebApi_Model_GetByIdAsync_Entry");
                var ret = await _modelService.GetByIdAsync(id);
                this._logger.LogInformation("WebApi_Model_GetByIdAsync_Entry");
                return Ok(ret);
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Model_GetAsync_Exception");
                string mensagem = "Erro ao consumir a controler Model, rota GetByIdAsync " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }
        }

        [HttpPost(Name = "InsertModel")]
        public async Task Post(ModelEntity entity)
        {
            try
            {
                this._logger.LogInformation("WebApi_Model_PostAsync_Entry");
                await _modelService.PostAsync(entity);
                this._logger.LogInformation("WebApi_Model_PostAsync_Exit");
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Model_PostAsync_Exception");
                string mensagem = "Erro ao consumir a controler Model, rota PostAsync " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }

        }

        [HttpPut(Name = "UpdateModel")]
        public async Task Put(ModelEntity entity)
        {
            try
            {
                this._logger.LogInformation("WebApi_Model_PutAsync_Entry");
                await _modelService.PutAsync(entity);
                this._logger.LogInformation("WebApi_Model_PutAsync_Exit");
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Model_PutAsync_Exception");
                string mensagem = "Erro ao consumir a controler Model, rota Put " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }

        }

        [HttpDelete("{id:int}")]
        public async Task Delete(int id)
        {
            try
            {
                this._logger.LogInformation("WebApi_Model_DeleteAsync_Entry");
                await _modelService.DeleteAsync(id);
                this._logger.LogInformation("WebApi_Model_DeleteAsync_Exit");
            }
            catch (Exception ex)
            {
                _logger.LogInformation("WebApi_Model_DeleteAsync_Exception");
                string mensagem = "Erro ao consumir a controler Model, rota DeleteAsync " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }
        }
    }
}