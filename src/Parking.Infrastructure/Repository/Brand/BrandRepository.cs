using Parking.Domain.Entities;
using Parking.Domain.SeedWork;
using System.Data;
using System.Data.SqlClient;

namespace Parking.Infrastructure.Repository.Brand
{
    public class BrandRepository : BaseRepository, IBrandRepository
    {
        public BrandRepository(ILogger logger) : base(logger) { }

        public void Delete(int id)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Brand_Delete");
                _commandText = "USP_Parking_Brand_Delete";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetSqlCommandVehicleBrandModelDelete(sqlCommand, id);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Brand_Delete");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Brand_Delete");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Brand, método DeleteAsync, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Brand_DeleteAsync");
                _commandText = "USP_Parking_Brand_Delete";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetSqlCommandVehicleBrandModelDelete(sqlCommand, id);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                await sqlCommand.ExecuteNonQueryAsync();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Brand_DeleteAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Brand_DeleteAsync");
                string mensagemErro = "Erro ao consumir a procedure " +_commandText+ " , está na camada Infrastructure, Repository, entidade Brand, método DeleteAsync, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public List<BrandEntity> Get()
        {
            List<BrandEntity> list = new List<BrandEntity>();
            try
            {
                _logger.TraceEntry("Infrastructure_Brand_Get");
                _commandText = "USP_Parking_Brand_Get";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        GetListBrand(sqlDataReader, list);
                    }
                }
                _logger.TraceExit("Infrastructure_Brand_Get");

            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Brand_Get");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Brand, método Get, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return list;
        }

        public async Task<List<BrandEntity>> GetAsync()
        {
            List<BrandEntity> list = new List<BrandEntity>();
            try
            {
                _logger.TraceEntry("Infrastructure_Brand_GetAsync");
                _commandText = "USP_Parking_Brand_Get";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                    {
                        GetListBrand(sqlDataReader, list);
                    }
                }
                _logger.TraceExit("Infrastructure_Brand_GetAsync");

            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Brand_GetAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Brand, método Get, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return list;
        }

        public BrandEntity GetById(int id)
        {
            BrandEntity entity = new BrandEntity();
            try
            {
                _logger.TraceEntry("Infrastructure_Brand_GetById");
                _commandText = "USP_Parking_Brand_GetById";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Id", id);
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        GetBrand(sqlDataReader, entity);
                    }
                }
                _logger.TraceExit("Infrastructure_Brand_GetById");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Brand_GetById");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Brand, método GetById, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return entity;
        }

        public async Task<BrandEntity> GetByIdAsync(int id)
        {
            BrandEntity entity = new BrandEntity();
            try
            {
                _logger.TraceEntry("Infrastructure_Brand_GetByIdAsync");
                _commandText = "USP_Parking_Brand_GetById";
                using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
                {
                    SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Id", id);
                    sqlConnection.Open();
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                    {
                        GetBrand(sqlDataReader, entity);
                    }
                }
                _logger.TraceExit("Infrastructure_Brand_GetByIdAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Brand_GetByIdAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Brand, método GetByIdAsync, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
            return entity;
        }

        public void Post(BrandEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Brand_Post");
                _commandText = "USP_Parking_Brand_Post";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetBrandInsert(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Brand_Post");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Brand_Post");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Brand, método Post, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PostAsync(BrandEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Brand_PostAsync");
                _commandText = "USP_Parking_Brand_Post";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetBrandInsert(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                await sqlCommand.ExecuteNonQueryAsync();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Brand_PostAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Brand_PostAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Brand, método PostAsync, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public void Put(BrandEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Brand_Put");
                _commandText = "USP_Parking_Brand_Put";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetBrandUpdate(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Brand_Put");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Brand_Put");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Brand, método Put, tipo síncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        public async Task PutAsync(BrandEntity entity)
        {
            try
            {
                _logger.TraceEntry("Infrastructure_Brand_PutAsync");
                _commandText = "USP_Parking_Brand_Put";
                SqlConnection sqlConnection = new SqlConnection(_connectionString);
                SqlCommand sqlCommand = new SqlCommand(_commandText, sqlConnection);
                GetBrandUpdate(sqlCommand, entity);
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                await sqlCommand.ExecuteNonQueryAsync();
                sqlConnection.Close();
                _logger.TraceExit("Infrastructure_Brand_PutAsync");
            }
            catch (ArgumentNullException ex)
            {
                _logger.TraceException("Infrastructure_Brand_PutAsync");
                string mensagemErro = "Erro ao consumir a procedure " + _commandText + " , está na camada Infrastructure, Repository, entidade Brand, método PutAsync, tipo assíncrono. " + ex.Message;
                throw new ArgumentNullException(mensagemErro);
            }
        }

        #region Helpers

        private static void GetListBrand(SqlDataReader sqlDataReader, List<BrandEntity> listVehicleBrandModel)
        {
            BrandEntity brandModel = new BrandEntity();
            GetBrand(sqlDataReader, brandModel);
            listVehicleBrandModel.Add(brandModel);
        }

        private static void GetBrand(SqlDataReader sqlDataReader, BrandEntity brandModel)
        {
            brandModel.Id = Convert.ToInt32(sqlDataReader["Id"]);
            brandModel.IdUser = Convert.ToInt32(sqlDataReader["IdUser"]);
            brandModel.Name = Convert.ToString(sqlDataReader["Name"]);
            brandModel.Status = Convert.ToBoolean(sqlDataReader["Status"]);
            brandModel.DateInsert = Convert.ToDateTime(sqlDataReader["DateInsert"]);
            brandModel.DateUpdate = Convert.ToDateTime(sqlDataReader["DateUpdate"]);
        }

        private static void GetBrandInsert(SqlCommand sqlCommand, BrandEntity entity)
        {
            sqlCommand.Parameters.AddWithValue("@IdUser", entity.IdUser);
            sqlCommand.Parameters.AddWithValue("@Name", entity.Name);
            sqlCommand.Parameters.AddWithValue("@Status", entity.Status);
            sqlCommand.Parameters.AddWithValue("@DateInsert", entity.DateInsert);
            sqlCommand.Parameters.AddWithValue("@DateUpdate", entity.DateUpdate);
        }

        private static void GetBrandUpdate(SqlCommand sqlCommand, BrandEntity entity)
        {
            sqlCommand.Parameters.AddWithValue("@Id", entity.Id);
            sqlCommand.Parameters.AddWithValue("@IdUser", entity.Id);
            sqlCommand.Parameters.AddWithValue("@Name", entity.Name);
            sqlCommand.Parameters.AddWithValue("@Status", entity.Status);
            sqlCommand.Parameters.AddWithValue("@DateInsert", entity.DateInsert);
            sqlCommand.Parameters.AddWithValue("@DateUpdate", entity.DateUpdate);
        }

        private static void GetSqlCommandVehicleBrandModelDelete(SqlCommand sqlCommand, int id)
        {
            sqlCommand.Parameters.AddWithValue("@Id", id);
        }

        #endregion

    }
}
