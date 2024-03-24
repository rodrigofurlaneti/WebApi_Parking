using Parking.Domain.Entities;
using Parking.Domain.SeedWork;
using Parking.Infrastructure.Repository.Model;

namespace Parking.Service.Service.Model
{
    public class ModelService : BaseService, IModelService
    {
        #region Property

        public readonly IModelRepository _modelRepository;


        #endregion

        #region Constructor

        public ModelService(ILogger logger, IModelRepository modelRepository) : base(logger) {
            _modelRepository = modelRepository;
        }

        #endregion

        #region Methods

        public void Delete(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Model_Delete");
                _modelRepository.Delete(id);
                this._logger.TraceExit("Service_Model_Delete");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Model_Delete");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Model, método Delete, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Model_DeleteAsync");
                await _modelRepository.DeleteAsync(id);
                this._logger.TraceExit("Service_Model_DeleteAsync");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Model_Delete");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Model, método DeleteAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public List<ModelEntity> Get()
        {
            try
            {
                this._logger.TraceEntry("Service_Model_Get");
                var ret = _modelRepository.Get();
                this._logger.TraceExit("Service_Model_Get");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Model_Get");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Model, método Get, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task<List<ModelEntity>> GetAsync()
        {
            try
            {
                this._logger.TraceEntry("Service_Model_GetAsync");
                var ret = await _modelRepository.GetAsync();
                this._logger.TraceExit("Service_Model_GetAsync");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Model_GetAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Model, método GetAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public ModelEntity GetById(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Model_GetById");
                var ret = _modelRepository.GetById(id);
                this._logger.TraceExit("Service_Model_GetById");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Model_GetById");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Model, método GetById, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task<ModelEntity> GetByIdAsync(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Model_GetByIdAsync");
                var ret = await _modelRepository.GetByIdAsync(id);
                this._logger.TraceExit("Service_Model_GetByIdAsync");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Model_GetByIdAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Model, método GetByIdAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public void Post(ModelEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Model_Post");
                _modelRepository.Post(entity);
                this._logger.TraceExit("Service_Model_Post");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Model_Post");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Model, método Post, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PostAsync(ModelEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Model_PostAsync");
                await _modelRepository.PostAsync(entity);
                this._logger.TraceExit("Service_Model_PostAsync");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Model_PostAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Model, método PostAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public void Put(ModelEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Model_Put");
                _modelRepository.Put(entity);
                this._logger.TraceExit("Service_Model_Put");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Model_Put");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Model, método Put, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PutAsync(ModelEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Model_PutAsync");
                await _modelRepository.PutAsync(entity);
                this._logger.TraceExit("Service_Model_PutAsync");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Model_PutAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Model, método PutAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        #endregion
    }
}
