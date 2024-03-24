using Parking.Domain.Entities;
using Parking.Domain.SeedWork;
using Parking.Infrastructure.Repository.Profile;

namespace Parking.Service.Service.Profile
{
    public class ProfileService : BaseService, IProfileService
    {
        #region Property

        public readonly IProfileRepository _brandRepository;


        #endregion

        #region Constructor

        public ProfileService(ILogger logger, IProfileRepository brandRepository) : base(logger) {
            _brandRepository = brandRepository;
        }

        #endregion

        #region Methods

        public void Delete(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Profile_Delete");
                _brandRepository.Delete(id);
                this._logger.TraceExit("Service_Profile_Delete");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Profile_Delete");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Profile, método Delete, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Profile_DeleteAsync");
                await _brandRepository.DeleteAsync(id);
                this._logger.TraceExit("Service_Profile_DeleteAsync");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Profile_Delete");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Profile, método DeleteAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public List<ProfileEntity> Get()
        {
            try
            {
                this._logger.TraceEntry("Service_Profile_Get");
                var ret = _brandRepository.Get();
                this._logger.TraceExit("Service_Profile_Get");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Profile_Get");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Profile, método Get, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task<List<ProfileEntity>> GetAsync()
        {
            try
            {
                this._logger.TraceEntry("Service_Profile_GetAsync");
                var ret = await _brandRepository.GetAsync();
                this._logger.TraceExit("Service_Profile_GetAsync");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Profile_GetAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Profile, método GetAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public ProfileEntity GetById(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Profile_GetById");
                var ret = _brandRepository.GetById(id);
                this._logger.TraceExit("Service_Profile_GetById");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Profile_GetById");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Profile, método GetById, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task<ProfileEntity> GetByIdAsync(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Profile_GetByIdAsync");
                var ret = await _brandRepository.GetByIdAsync(id);
                this._logger.TraceExit("Service_Profile_GetByIdAsync");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Profile_GetByIdAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Profile, método GetByIdAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public void Post(ProfileEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Profile_Post");
                _brandRepository.Post(entity);
                this._logger.TraceExit("Service_Profile_Post");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Profile_Post");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Profile, método Post, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PostAsync(ProfileEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Profile_PostAsync");
                await _brandRepository.PostAsync(entity);
                this._logger.TraceExit("Service_Profile_PostAsync");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Profile_PostAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Profile, método PostAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public void Put(ProfileEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Profile_Put");
                _brandRepository.Put(entity);
                this._logger.TraceExit("Service_Profile_Put");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Profile_Put");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Profile, método Put, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PutAsync(ProfileEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Profile_PutAsync");
                await _brandRepository.PutAsync(entity);
                this._logger.TraceExit("Service_Profile_PutAsync");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Profile_PutAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Profile, método PutAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        #endregion
    }
}
