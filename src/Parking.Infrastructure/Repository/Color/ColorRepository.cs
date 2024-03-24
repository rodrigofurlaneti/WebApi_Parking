using Parking.Domain.Entities;
using Parking.Domain.SeedWork;
using System.Data;
using System.Data.SqlClient;

namespace Parking.Infrastructure.Repository.Color
{
    public class ColorRepository : BaseRepository, IColorRepository
    {
        public ColorRepository(ILogger logger) : base(logger) { }

        public void Delete(int id)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Color_Delete");
                _commandText = "USP_Parking_Color_Delete";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetColorDelete(sqlCommand, id);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Color_Delete");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Color_Delete");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Color, método DeleteAsync, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Color_DeleteAsync");
                _commandText = "USP_Parking_Color_Delete";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetColorDelete(sqlCommand, id);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                await sqlCommand.ExecuteNonQueryAsync();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Color_DeleteAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Color_DeleteAsync");
                string mensagemErro = "Erro ao consumir a procedure " +_commandText+ " , está na camada Infrastructure, Repository, entidade Color, método DeleteAsync, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public List<ColorEntity> Get()
        {
            List<ColorEntity> list = new List<ColorEntity>();
            try
            {
                _logger.TraceEntry("Infrastructure_Color_Get");
                _commandText = "USP_Parking_Color_Get";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        GetListColor(sqlDataReader, list);
                    }
                }
                _logger.TraceExit("Infrastructure_Color_Get");

            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Color_Get");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Color, método Get, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return list;
        }

        public async Task<List<ColorEntity>> GetAsync()
        {
            List<ColorEntity> list = new List<ColorEntity>();
            try
            {
                _logger.TraceEntry("Infrastructure_Color_GetAsync");
                _commandText = "USP_Parking_Color_Get";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                    {
                        GetListColor(sqlDataReader, list);
                    }
                }
                _logger.TraceExit("Infrastructure_Color_GetAsync");

            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Color_GetAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Color, método Get, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return list;
        }

        public ColorEntity GetById(int id)
        {
            ColorEntity entity = new ColorEntity();
            try
            {
                _logger.TraceEntry("Infrastructure_Color_GetById");
                _commandText = "USP_Parking_Color_GetById";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Id", id);
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        GetColor(sqlDataReader, entity);
                    }
                }
                _logger.TraceExit("Infrastructure_Color_GetById");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Color_GetById");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Color, método GetById, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return entity;
        }

        public async Task<ColorEntity> GetByIdAsync(int id)
        {
            ColorEntity entity = new ColorEntity();
            try
            {
                _logger.TraceEntry("Infrastructure_Color_GetByIdAsync");
                _commandText = "USP_Parking_Color_GetById";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Id", id);
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                    {
                        GetColor(sqlDataReader, entity);
                    }
                }
                _logger.TraceExit("Infrastructure_Color_GetByIdAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Color_GetByIdAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Color, método GetByIdAsync, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return entity;
        }

        public void Post(ColorEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Color_Post");
                _commandText = "USP_Parking_Color_Post";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetColorInsert(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Color_Post");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Color_Post");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Color, método Post, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PostAsync(ColorEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Color_PostAsync");
                _commandText = "USP_Parking_Color_Post";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetColorInsert(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                await sqlCommand.ExecuteNonQueryAsync();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Color_PostAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Color_PostAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Color, método PostAsync, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public void Put(ColorEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Color_Put");
                _commandText = "USP_Parking_Color_Put";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetColorUpdate(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Color_Put");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Color_Put");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Color, método Put, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PutAsync(ColorEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Color_PutAsync");
                _commandText = "USP_Parking_Color_Put";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetColorUpdate(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                await sqlCommand.ExecuteNonQueryAsync();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Color_PutAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Color_PutAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Color, método PutAsync, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        #region Helpers

        private static void GetListColor(SqlDataReader sqlDataReader, List<ColorEntity> listVehicleColorModel)
        {
            ColorEntity brandModel = new ColorEntity();
            GetColor(sqlDataReader, brandModel);
            listVehicleColorModel.Add(brandModel);
        }

        private static void GetColor(SqlDataReader sqlDataReader, ColorEntity brandModel)
        {
            brandModel.Id = Convert.ToInt32(sqlDataReader["Id"]);
            brandModel.IdUser = Convert.ToInt32(sqlDataReader["IdUser"]);
            brandModel.Name = Convert.ToString(sqlDataReader["Name"]);
            brandModel.Status = Convert.ToBoolean(sqlDataReader["Status"]);
            brandModel.DateInsert = Convert.ToDateTime(sqlDataReader["DateInsert"]);
            brandModel.DateUpdate = Convert.ToDateTime(sqlDataReader["DateUpdate"]);
        }

        private static void GetColorInsert(SqlCommand sqlCommand, ColorEntity entity)
        {
            sqlCommand.Parameters.AddWithValue("@IdUser", entity.IdUser);
            sqlCommand.Parameters.AddWithValue("@Name", entity.Name);
            sqlCommand.Parameters.AddWithValue("@Status", entity.Status);
            sqlCommand.Parameters.AddWithValue("@DateInsert", entity.DateInsert);
            sqlCommand.Parameters.AddWithValue("@DateUpdate", entity.DateUpdate);
        }

        private static void GetColorUpdate(SqlCommand sqlCommand, ColorEntity entity)
        {
            sqlCommand.Parameters.AddWithValue("@Id", entity.Id);
            sqlCommand.Parameters.AddWithValue("@IdUser", entity.IdUser);
            sqlCommand.Parameters.AddWithValue("@Name", entity.Name);
            sqlCommand.Parameters.AddWithValue("@Status", entity.Status);
            sqlCommand.Parameters.AddWithValue("@DateInsert", entity.DateInsert);
            sqlCommand.Parameters.AddWithValue("@DateUpdate", entity.DateUpdate);
        }

        private static void GetColorDelete(SqlCommand sqlCommand, int id)
        {
            sqlCommand.Parameters.AddWithValue("@Id", id);
        }

        #endregion

    }
}
