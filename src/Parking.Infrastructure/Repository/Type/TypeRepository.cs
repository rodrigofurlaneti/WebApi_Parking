using Parking.Domain.Entities;
using Parking.Domain.SeedWork;
using System.Data;
using System.Data.SqlClient;

namespace Parking.Infrastructure.Repository.Type
{
    public class TypeRepository : BaseRepository, ITypeRepository
    {
        public TypeRepository(ILogger logger) : base(logger) { }

        public void Delete(int id)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Type_Delete");
                _commandText = "USP_Parking_Type_Delete";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetTypeDelete(sqlCommand, id);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Type_Delete");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Type_Delete");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Type, método DeleteAsync, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Type_DeleteAsync");
                _commandText = "USP_Parking_Type_Delete";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetTypeDelete(sqlCommand, id);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                await sqlCommand.ExecuteNonQueryAsync();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Type_DeleteAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Type_DeleteAsync");
                string mensagemErro = "Erro ao consumir a procedure " +_commandText+ " , está na camada Infrastructure, Repository, entidade Type, método DeleteAsync, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public List<TypeEntity> Get()
        {
            List<TypeEntity> list = new List<TypeEntity>();
            try
            {
                _logger.TraceEntry("Infrastructure_Type_Get");
                _commandText = "USP_Parking_Type_Get";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        GetListType(sqlDataReader, list);
                    }
                }
                _logger.TraceExit("Infrastructure_Type_Get");

            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Type_Get");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Type, método Get, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return list;
        }

        public async Task<List<TypeEntity>> GetAsync()
        {
            List<TypeEntity> list = new List<TypeEntity>();
            try
            {
                _logger.TraceEntry("Infrastructure_Type_GetAsync");
                _commandText = "USP_Parking_Type_Get";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                    {
                        GetListType(sqlDataReader, list);
                    }
                }
                _logger.TraceExit("Infrastructure_Type_GetAsync");

            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Type_GetAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Type, método Get, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return list;
        }

        public TypeEntity GetById(int id)
        {
            TypeEntity entity = new TypeEntity();
            try
            {
                _logger.TraceEntry("Infrastructure_Type_GetById");
                _commandText = "USP_Parking_Type_GetById";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Id", id);
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        GetType(sqlDataReader, entity);
                    }
                }
                _logger.TraceExit("Infrastructure_Type_GetById");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Type_GetById");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Type, método GetById, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return entity;
        }

        public async Task<TypeEntity> GetByIdAsync(int id)
        {
            TypeEntity entity = new TypeEntity();
            try
            {
                _logger.TraceEntry("Infrastructure_Type_GetByIdAsync");
                _commandText = "USP_Parking_Type_GetById";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Id", id);
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                    {
                        GetType(sqlDataReader, entity);
                    }
                }
                _logger.TraceExit("Infrastructure_Type_GetByIdAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Type_GetByIdAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Type, método GetByIdAsync, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return entity;
        }

        public void Post(TypeEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Type_Post");
                _commandText = "USP_Parking_Type_Post";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetTypeInsert(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Type_Post");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Type_Post");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Type, método Post, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PostAsync(TypeEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Type_PostAsync");
                _commandText = "USP_Parking_Type_Post";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetTypeInsert(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                await sqlCommand.ExecuteNonQueryAsync();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Type_PostAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Type_PostAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Type, método PostAsync, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public void Put(TypeEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Type_Put");
                _commandText = "USP_Parking_Type_Put";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetTypeUpdate(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Type_Put");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Type_Put");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Type, método Put, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PutAsync(TypeEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Type_PutAsync");
                _commandText = "USP_Parking_Type_Put";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetTypeUpdate(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                await sqlCommand.ExecuteNonQueryAsync();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Type_PutAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Type_PutAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Type, método PutAsync, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        #region Helpers

        private static void GetListType(SqlDataReader sqlDataReader, List<TypeEntity> listVehicleTypeModel)
        {
            TypeEntity brandModel = new TypeEntity();
            GetType(sqlDataReader, brandModel);
            listVehicleTypeModel.Add(brandModel);
        }

        private static void GetType(SqlDataReader sqlDataReader, TypeEntity brandModel)
        {
            brandModel.Id = Convert.ToInt32(sqlDataReader["Id"]);
            brandModel.IdUser = Convert.ToInt32(sqlDataReader["IdUser"]);
            brandModel.Name = Convert.ToString(sqlDataReader["Name"]);
            brandModel.Status = Convert.ToBoolean(sqlDataReader["Status"]);
            brandModel.DateInsert = Convert.ToDateTime(sqlDataReader["DateInsert"]);
            brandModel.DateUpdate = Convert.ToDateTime(sqlDataReader["DateUpdate"]);
        }

        private static void GetTypeInsert(SqlCommand sqlCommand, TypeEntity entity)
        {
            sqlCommand.Parameters.AddWithValue("@IdUser", entity.IdUser);
            sqlCommand.Parameters.AddWithValue("@Name", entity.Name);
            sqlCommand.Parameters.AddWithValue("@Status", entity.Status);
            sqlCommand.Parameters.AddWithValue("@DateInsert", entity.DateInsert);
            sqlCommand.Parameters.AddWithValue("@DateUpdate", entity.DateUpdate);
        }

        private static void GetTypeUpdate(SqlCommand sqlCommand, TypeEntity entity)
        {
            sqlCommand.Parameters.AddWithValue("@Id", entity.Id);
            sqlCommand.Parameters.AddWithValue("@IdUser", entity.IdUser);
            sqlCommand.Parameters.AddWithValue("@Name", entity.Name);
            sqlCommand.Parameters.AddWithValue("@Status", entity.Status);
            sqlCommand.Parameters.AddWithValue("@DateInsert", entity.DateInsert);
            sqlCommand.Parameters.AddWithValue("@DateUpdate", entity.DateUpdate);
        }

        private static void GetTypeDelete(SqlCommand sqlCommand, int id)
        {
            sqlCommand.Parameters.AddWithValue("@Id", id);
        }

        #endregion

    }
}
