using Microsoft.AspNetCore.Mvc;
using Parking.Domain.Entities;
using Parking.Service.Service;
using Parking.Service.Service.Brand;

namespace Parking.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrandController : ControllerBase
    {
        private readonly ILogger<BrandController> _logger;
        private readonly IBrandService _brandService;

        public BrandController(ILogger<BrandController> logger, IBrandService brandService)
        {
            this._logger = logger;
            this._brandService = brandService;
        }

        [HttpGet(Name = "GetBrand")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BrandEntity>))]
        public async Task<IActionResult> GetBrand()
        {
            try
            {
                this._logger.LogInformation("WebApi_Brand_GetAsync_Entry");
                var ret = await _brandService.GetAsync();
                this._logger.LogInformation("WebApi_Brand_GetAsync_Exit");
                return Ok(ret);
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Brand_GetAsync_Exception");
                string mensagem = "Erro ao consumir a controler Brand, rota Get " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<BrandEntity>))]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                this._logger.LogInformation("WebApi_Brand_GetByIdAsync_Entry");
                var ret = await _brandService.GetByIdAsync(id);
                this._logger.LogInformation("WebApi_Brand_GetByIdAsync_Entry");
                return Ok(ret);
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Brand_GetAsync_Exception");
                string mensagem = "Erro ao consumir a controler Brand, rota GetByIdAsync " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }
        }

        [HttpPost(Name = "InsertBrand")]
        public async Task Post(BrandEntity entity)
        {
            try
            {
                this._logger.LogInformation("WebApi_Brand_PostAsync_Entry");
                await _brandService.PostAsync(entity);
                this._logger.LogInformation("WebApi_Brand_PostAsync_Exit");
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Brand_PostAsync_Exception");
                string mensagem = "Erro ao consumir a controler Brand, rota PostAsync " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }

        }

        [HttpPut(Name = "UpdateBrand")]
        public async Task Put(BrandEntity entity)
        {
            try
            {
                this._logger.LogInformation("WebApi_Brand_PutAsync_Entry");
                await _brandService.PutAsync(entity);
                this._logger.LogInformation("WebApi_Brand_PutAsync_Exit");
            }
            catch (Exception ex)
            {
                this._logger.LogInformation("WebApi_Brand_PutAsync_Exception");
                string mensagem = "Erro ao consumir a controler Brand, rota Put " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }

        }

        [HttpDelete("{id:int}")]
        public async Task Delete(int id)
        {
            try
            {
                this._logger.LogInformation("WebApi_Brand_DeleteAsync_Entry");
                await _brandService.DeleteAsync(id);
                this._logger.LogInformation("WebApi_Brand_DeleteAsync_Exit");
            }
            catch (Exception ex)
            {
                _logger.LogInformation("WebApi_Brand_DeleteAsync_Exception");
                string mensagem = "Erro ao consumir a controler Brand, rota DeleteAsync " + ex.Message;
                throw new ArgumentNullException(mensagem);
            }
        }
    }
}