using Parking.Domain.Entities;
using Parking.Domain.SeedWork;
using System.Data;
using System.Data.SqlClient;

namespace Parking.Infrastructure.Repository.Model
{
    public class ModelRepository : BaseRepository, IModelRepository
    {
        public ModelRepository(ILogger logger) : base(logger) { }

        public void Delete(int id)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Model_Delete");
                _commandText = "USP_Parking_Model_Delete";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetModelDelete(sqlCommand, id);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Model_Delete");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Model_Delete");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Model, método DeleteAsync, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Model_DeleteAsync");
                _commandText = "USP_Parking_Model_Delete";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetModelDelete(sqlCommand, id);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                await sqlCommand.ExecuteNonQueryAsync();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Model_DeleteAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Model_DeleteAsync");
                string mensagemErro = "Erro ao consumir a procedure " +_commandText+ " , está na camada Infrastructure, Repository, entidade Model, método DeleteAsync, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public List<ModelEntity> Get()
        {
            List<ModelEntity> list = new List<ModelEntity>();
            try
            {
                _logger.TraceEntry("Infrastructure_Model_Get");
                _commandText = "USP_Parking_Model_Get";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        GetListModel(sqlDataReader, list);
                    }
                }
                _logger.TraceExit("Infrastructure_Model_Get");

            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Model_Get");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Model, método Get, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return list;
        }

        public async Task<List<ModelEntity>> GetAsync()
        {
            List<ModelEntity> list = new List<ModelEntity>();
            try
            {
                _logger.TraceEntry("Infrastructure_Model_GetAsync");
                _commandText = "USP_Parking_Model_Get";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                    {
                        GetListModel(sqlDataReader, list);
                    }
                }
                _logger.TraceExit("Infrastructure_Model_GetAsync");

            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Model_GetAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Model, método Get, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return list;
        }

        public ModelEntity GetById(int id)
        {
            ModelEntity entity = new ModelEntity();
            try
            {
                _logger.TraceEntry("Infrastructure_Model_GetById");
                _commandText = "USP_Parking_Model_GetById";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Id", id);
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        GetModel(sqlDataReader, entity);
                    }
                }
                _logger.TraceExit("Infrastructure_Model_GetById");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Model_GetById");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Model, método GetById, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return entity;
        }

        public async Task<ModelEntity> GetByIdAsync(int id)
        {
            ModelEntity entity = new ModelEntity();
            try
            {
                _logger.TraceEntry("Infrastructure_Model_GetByIdAsync");
                _commandText = "USP_Parking_Model_GetById";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Id", id);
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                    {
                        GetModel(sqlDataReader, entity);
                    }
                }
                _logger.TraceExit("Infrastructure_Model_GetByIdAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Model_GetByIdAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Model, método GetByIdAsync, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return entity;
        }

        public void Post(ModelEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Model_Post");
                _commandText = "USP_Parking_Model_Post";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetModelInsert(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Model_Post");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Model_Post");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Model, método Post, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PostAsync(ModelEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Model_PostAsync");
                _commandText = "USP_Parking_Model_Post";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetModelInsert(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                await sqlCommand.ExecuteNonQueryAsync();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Model_PostAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Model_PostAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Model, método PostAsync, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public void Put(ModelEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Model_Put");
                _commandText = "USP_Parking_Model_Put";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetModelUpdate(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Model_Put");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Model_Put");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Model, método Put, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PutAsync(ModelEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Model_PutAsync");
                _commandText = "USP_Parking_Model_Put";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetModelUpdate(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                await sqlCommand.ExecuteNonQueryAsync();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Model_PutAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Model_PutAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Model, método PutAsync, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        #region Helpers

        private static void GetListModel(SqlDataReader sqlDataReader, List<ModelEntity> listVehicleModelModel)
        {
            ModelEntity brandModel = new ModelEntity();
            GetModel(sqlDataReader, brandModel);
            listVehicleModelModel.Add(brandModel);
        }

        private static void GetModel(SqlDataReader sqlDataReader, ModelEntity brandModel)
        {
            brandModel.Id = Convert.ToInt32(sqlDataReader["Id"]);
            brandModel.IdUser = Convert.ToInt32(sqlDataReader["IdUser"]);
            brandModel.Name = Convert.ToString(sqlDataReader["Name"]);
            brandModel.Status = Convert.ToBoolean(sqlDataReader["Status"]);
            brandModel.DateInsert = Convert.ToDateTime(sqlDataReader["DateInsert"]);
            brandModel.DateUpdate = Convert.ToDateTime(sqlDataReader["DateUpdate"]);
        }

        private static void GetModelInsert(SqlCommand sqlCommand, ModelEntity entity)
        {
            sqlCommand.Parameters.AddWithValue("@IdUser", entity.IdUser);
            sqlCommand.Parameters.AddWithValue("@Name", entity.Name);
            sqlCommand.Parameters.AddWithValue("@Status", entity.Status);
            sqlCommand.Parameters.AddWithValue("@DateInsert", entity.DateInsert);
            sqlCommand.Parameters.AddWithValue("@DateUpdate", entity.DateUpdate);
        }

        private static void GetModelUpdate(SqlCommand sqlCommand, ModelEntity entity)
        {
            sqlCommand.Parameters.AddWithValue("@Id", entity.Id);
            sqlCommand.Parameters.AddWithValue("@IdUser", entity.IdUser);
            sqlCommand.Parameters.AddWithValue("@Name", entity.Name);
            sqlCommand.Parameters.AddWithValue("@Status", entity.Status);
            sqlCommand.Parameters.AddWithValue("@DateInsert", entity.DateInsert);
            sqlCommand.Parameters.AddWithValue("@DateUpdate", entity.DateUpdate);
        }

        private static void GetModelDelete(SqlCommand sqlCommand, int id)
        {
            sqlCommand.Parameters.AddWithValue("@Id", id);
        }

        #endregion

    }
}
