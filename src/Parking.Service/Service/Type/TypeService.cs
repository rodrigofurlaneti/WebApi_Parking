using Parking.Domain.Entities;
using Parking.Domain.SeedWork;
using Parking.Infrastructure.Repository.Type;

namespace Parking.Service.Service.Type
{
    public class TypeService : BaseService, ITypeService
    {
        #region Property

        public readonly ITypeRepository _colorRepository;


        #endregion

        #region Constructor

        public TypeService(ILogger logger, ITypeRepository colorRepository) : base(logger) {
            _colorRepository = colorRepository;
        }

        #endregion

        #region Methods

        public void Delete(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Type_Delete");
                _colorRepository.Delete(id);
                this._logger.TraceExit("Service_Type_Delete");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Type_Delete");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Type, método Delete, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Type_DeleteAsync");
                await _colorRepository.DeleteAsync(id);
                this._logger.TraceExit("Service_Type_DeleteAsync");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Type_Delete");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Type, método DeleteAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public List<TypeEntity> Get()
        {
            try
            {
                this._logger.TraceEntry("Service_Type_Get");
                var ret = _colorRepository.Get();
                this._logger.TraceExit("Service_Type_Get");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Type_Get");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Type, método Get, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task<List<TypeEntity>> GetAsync()
        {
            try
            {
                this._logger.TraceEntry("Service_Type_GetAsync");
                var ret = await _colorRepository.GetAsync();
                this._logger.TraceExit("Service_Type_GetAsync");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Type_GetAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Type, método GetAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public TypeEntity GetById(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Type_GetById");
                var ret = _colorRepository.GetById(id);
                this._logger.TraceExit("Service_Type_GetById");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Type_GetById");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Type, método GetById, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task<TypeEntity> GetByIdAsync(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Type_GetByIdAsync");
                var ret = await _colorRepository.GetByIdAsync(id);
                this._logger.TraceExit("Service_Type_GetByIdAsync");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Type_GetByIdAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Type, método GetByIdAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public void Post(TypeEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Type_Post");
                _colorRepository.Post(entity);
                this._logger.TraceExit("Service_Type_Post");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Type_Post");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Type, método Post, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PostAsync(TypeEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Type_PostAsync");
                await _colorRepository.PostAsync(entity);
                this._logger.TraceExit("Service_Type_PostAsync");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Type_PostAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Type, método PostAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public void Put(TypeEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Type_Put");
                _colorRepository.Put(entity);
                this._logger.TraceExit("Service_Type_Put");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Type_Put");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Type, método Put, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PutAsync(TypeEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Type_PutAsync");
                await _colorRepository.PutAsync(entity);
                this._logger.TraceExit("Service_Type_PutAsync");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Type_PutAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Type, método PutAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        #endregion
    }
}
