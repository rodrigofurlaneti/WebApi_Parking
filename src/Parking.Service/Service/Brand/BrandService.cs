using Parking.Domain.Entities;
using Parking.Domain.SeedWork;
using Parking.Infrastructure.Repository.Brand;

namespace Parking.Service.Service.Brand
{
    public class BrandService : BaseService, IBrandService
    {
        #region Property

        public readonly IBrandRepository _brandRepository;


        #endregion

        #region Constructor

        public BrandService(ILogger logger, IBrandRepository brandRepository) : base(logger) {
            _brandRepository = brandRepository;
        }

        #endregion

        #region Methods

        public void Delete(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Brand_Delete");
                _brandRepository.Delete(id);
                this._logger.TraceExit("Service_Brand_Delete");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Brand_Delete");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Brand, método Delete, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Brand_DeleteAsync");
                await _brandRepository.DeleteAsync(id);
                this._logger.TraceExit("Service_Brand_DeleteAsync");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Brand_Delete");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Brand, método DeleteAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public List<BrandEntity> Get()
        {
            try
            {
                this._logger.TraceEntry("Service_Brand_Get");
                var ret = _brandRepository.Get();
                this._logger.TraceExit("Service_Brand_Get");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Brand_Get");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Brand, método Get, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task<List<BrandEntity>> GetAsync()
        {
            try
            {
                this._logger.TraceEntry("Service_Brand_GetAsync");
                var ret = await _brandRepository.GetAsync();
                this._logger.TraceExit("Service_Brand_GetAsync");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Brand_GetAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Brand, método GetAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public BrandEntity GetById(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Brand_GetById");
                var ret = _brandRepository.GetById(id);
                this._logger.TraceExit("Service_Brand_GetById");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Brand_GetById");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Brand, método GetById, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task<BrandEntity> GetByIdAsync(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Brand_GetByIdAsync");
                var ret = await _brandRepository.GetByIdAsync(id);
                this._logger.TraceExit("Service_Brand_GetByIdAsync");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Brand_GetByIdAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Brand, método GetByIdAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public void Post(BrandEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Brand_Post");
                _brandRepository.Post(entity);
                this._logger.TraceExit("Service_Brand_Post");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Brand_Post");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Brand, método Post, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PostAsync(BrandEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Brand_PostAsync");
                await _brandRepository.PostAsync(entity);
                this._logger.TraceExit("Service_Brand_PostAsync");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Brand_PostAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Brand, método PostAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public void Put(BrandEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Brand_Put");
                _brandRepository.Put(entity);
                this._logger.TraceExit("Service_Brand_Put");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Brand_Put");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Brand, método Put, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PutAsync(BrandEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Brand_PutAsync");
                await _brandRepository.PutAsync(entity);
                this._logger.TraceExit("Service_Brand_PutAsync");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Brand_PutAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Brand, método PutAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        #endregion
    }
}
