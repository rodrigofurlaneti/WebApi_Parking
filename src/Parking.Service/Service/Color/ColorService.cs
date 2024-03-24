using Parking.Domain.Entities;
using Parking.Domain.SeedWork;
using Parking.Infrastructure.Repository.Color;

namespace Parking.Service.Service.Color
{
    public class ColorService : BaseService, IColorService
    {
        #region Property

        public readonly IColorRepository _colorRepository;


        #endregion

        #region Constructor

        public ColorService(ILogger logger, IColorRepository colorRepository) : base(logger) {
            _colorRepository = colorRepository;
        }

        #endregion

        #region Methods

        public void Delete(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Color_Delete");
                _colorRepository.Delete(id);
                this._logger.TraceExit("Service_Color_Delete");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Color_Delete");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Color, método Delete, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Color_DeleteAsync");
                await _colorRepository.DeleteAsync(id);
                this._logger.TraceExit("Service_Color_DeleteAsync");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Color_Delete");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Color, método DeleteAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public List<ColorEntity> Get()
        {
            try
            {
                this._logger.TraceEntry("Service_Color_Get");
                var ret = _colorRepository.Get();
                this._logger.TraceExit("Service_Color_Get");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Color_Get");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Color, método Get, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task<List<ColorEntity>> GetAsync()
        {
            try
            {
                this._logger.TraceEntry("Service_Color_GetAsync");
                var ret = await _colorRepository.GetAsync();
                this._logger.TraceExit("Service_Color_GetAsync");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Color_GetAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Color, método GetAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public ColorEntity GetById(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Color_GetById");
                var ret = _colorRepository.GetById(id);
                this._logger.TraceExit("Service_Color_GetById");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Color_GetById");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Color, método GetById, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task<ColorEntity> GetByIdAsync(int id)
        {
            try
            {
                this._logger.TraceEntry("Service_Color_GetByIdAsync");
                var ret = await _colorRepository.GetByIdAsync(id);
                this._logger.TraceExit("Service_Color_GetByIdAsync");
                return ret;
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Color_GetByIdAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Color, método GetByIdAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public void Post(ColorEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Color_Post");
                _colorRepository.Post(entity);
                this._logger.TraceExit("Service_Color_Post");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Color_Post");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Color, método Post, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PostAsync(ColorEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Color_PostAsync");
                await _colorRepository.PostAsync(entity);
                this._logger.TraceExit("Service_Color_PostAsync");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Color_PostAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Color, método PostAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public void Put(ColorEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Color_Put");
                _colorRepository.Put(entity);
                this._logger.TraceExit("Service_Color_Put");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Color_Put");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Color, método Put, tipo síncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PutAsync(ColorEntity entity)
        {
            try
            {
                this._logger.TraceEntry("Service_Color_PutAsync");
                await _colorRepository.PutAsync(entity);
                this._logger.TraceExit("Service_Color_PutAsync");
            }
            catch (ArgumentNullException ex)
            {
                this._logger.TraceException("Service_Color_PutAsync");
                string mensagemErro = "Erro ao consumir a camada Service, entidade Color, método PutAsync, tipo assíncrono " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        #endregion
    }
}
