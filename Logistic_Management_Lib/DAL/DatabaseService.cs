//using System;
//using System.Data;
//using System.Configuration;
//using System.Data.SqlClient;
//using Microsoft.Extensions.Configuration;
//using System.Xml;

//namespace Logistic_Management_Lib.DAL
//{
//    public class DataAccess : IDisposable
//    {
//        private readonly string _connectionString;
//        public IConfigurationRoot Configuration { get; }


//        SqlConnection Connection;
//        public SqlTransaction CurrentTransaction;
//        public SqlCommand Command;

//        public DataAccess()
//        {
//            this.CreateConnection();
//        }

//        public DataAccess(string connectionStringName)
//        {
//            this.CreateConnection(connectionStringName);
//        }

//        public virtual void CreateConnection()
//        {
//            this.CreateConnection("DefaultConnection");
//        }

//        public virtual void CreateConnection(string connectionStringName)
//        {
//            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings");
//            if ((this.CurrentTransaction == null))
//            {
//                if ((builder[connectionStringName] != null))
//                {
//                    string connStr = builder[connectionStringName];
//                    Connection = new SqlConnection(connStr);
//                }
//                else
//                {
//                    throw new ApplicationException((connectionStringName + " parameter not defined in config file."));
//                }
//            }
//        }

//        public virtual void AddParameter(string name, object value, ParameterDirection direction)
//        {
//            if ((this.Command == null))
//            {
//                return;
//            }
//            if (string.IsNullOrEmpty(name))
//            {
//                return;
//            }
//            SqlParameter parameter = new SqlParameter(name, this.GetValue(value));
//            parameter.Direction = direction;
//            this.Command.Parameters.Add(parameter);
//        }

//        public virtual void CreateSQLCommand(string cSQL)
//        {
//            if ((Connection == null))
//            {
//                throw new ApplicationException("Call CreateConnection method before using the connection.");
//            }
//            //  string cCond = "SET ARITHABORT ON;\n ";
//            this.Command = new SqlCommand(cSQL, this.Connection);
//            this.Command.CommandType = CommandType.Text;
//            this.Command.CommandTimeout = 200;
//            if (CurrentTransaction != null)
//            {
//                this.Command.Transaction = CurrentTransaction;
//            }
//            if (this.Command != null && this.Command.Parameters != null && this.Command.Parameters.Count > 0)
//            {
//                this.Command.Parameters.Clear();
//            }
//        }

//        public DataTable ExecuteSqlQuery(string sqlQuery)
//        {
//            DataTable dataTable = new DataTable();

//            try
//            {
//                using (SqlConnection connection = new SqlConnection(_connectionString))
//                {
//                    connection.OpenAsync();

//                    SqlCommand command = new SqlCommand(sqlQuery, connection);
//                    command.CommandType = CommandType.Text;
//                    SqlDataAdapter adapter = new SqlDataAdapter(command);
//                    adapter.Fill(dataTable);
//                }
//            }
//            catch (Exception ex)
//            {
//                // Handle exception
//                Console.WriteLine($"Error executing SQL query: {ex.Message}");
//            }

//            return dataTable;
//        }

//        public virtual void CreateProcedureCommand(string storedProcedureName)
//        {
//            if ((Connection == null))
//            {
//                throw new ApplicationException("Call CreateConnection method before using the connection.");
//            }
//            this.Command = new SqlCommand(storedProcedureName, this.Connection);
//            this.Command.CommandType = CommandType.StoredProcedure;
//            this.Command.CommandTimeout = 200;
//            if (CurrentTransaction != null)
//            {
//                this.Command.Transaction = CurrentTransaction;
//            }
//            if (this.Command != null && this.Command.Parameters != null && this.Command.Parameters.Count > 0)
//            {
//                this.Command.Parameters.Clear();
//            }
//        }

//        public virtual DataSet ExecuteDataSet()
//        {
//            if ((this.Command == null))
//            {
//                throw new ApplicationException("The command object is not defined.");
//            }
//            if ((Connection == null))
//            {
//                throw new ApplicationException("Call CreateConnection method before using the connection.");
//            }
//            SqlDataAdapter da = null;
//            //Changed Sayli 29Oct15
//            //DataSet ds;
//            DataSet ds = null;
//            //
//            ConnectionState initialState = ConnectionState.Closed;
//            try
//            {
//                this.QuietOpen(out initialState);
//                da = new SqlDataAdapter(this.Command);
//                ds = new DataSet();
//                da.Fill(ds);
//            }
//            catch (System.Exception ex)
//            {
//                throw;
//            }
//            finally
//            {
//                if ((da != null))
//                {
//                    da.Dispose();
//                }
//                //Added Sayli 29Oct15
//                if (ds != null)
//                {
//                    ds.Dispose();
//                }
//                //
//            }
//            return ds;
//        }

//        public virtual DataSet ExecuteDataReader_To_DataSet()
//        {
//            DataSet ds = null;
//            if ((this.Command == null))
//            {
//                throw new ApplicationException("The command object is not defined.");
//            }
//            if ((Connection == null))
//            {
//                throw new ApplicationException("Call CreateConnection method before using the connection.");
//            }
//            ConnectionState initialState = ConnectionState.Closed;
//            SqlDataReader reader = null;
//            try
//            {
//                ds = new DataSet();
//                this.QuietOpen(out initialState);
//                reader = this.Command.ExecuteReader(CommandBehavior.CloseConnection);
//                DataTable dt = new DataTable();
//                dt.Load(reader);
//                ds.Tables.Add(dt);
//            }
//            catch (System.Exception)
//            {
//                throw;
//            }
//            return ds;
//        }

//        public virtual SqlDataReader ExecuteDataReader()
//        {
//            if ((this.Command == null))
//            {
//                throw new ApplicationException("The command object is not defined.");
//            }
//            if ((Connection == null))
//            {
//                throw new ApplicationException("Call CreateConnection method before using the connection.");
//            }
//            ConnectionState initialState = ConnectionState.Closed;
//            SqlDataReader reader = null;
//            try
//            {
//                this.QuietOpen(out initialState);
//                reader = this.Command.ExecuteReader(CommandBehavior.CloseConnection);
//            }
//            catch (System.Exception)
//            {
//                throw;
//            }
//            return reader;
//        }

//        public virtual int ExecuteNonQuery()
//        {
//            if ((this.Command == null))
//            {
//                throw new ApplicationException("The command object is not defined.");
//            }
//            if ((Connection == null))
//            {
//                throw new ApplicationException("Call CreateConnection method before using the connection.");
//            }
//            ConnectionState initialState = ConnectionState.Closed;
//            int value;
//            try
//            {
//                this.QuietOpen(out initialState);
//                if (this.CurrentTransaction != null) this.Command.Transaction = this.CurrentTransaction;
//                value = this.Command.ExecuteNonQuery();
//            }
//            catch (System.Exception)
//            {
//                throw;
//            }
//            finally
//            {
//                this.QuietClose(initialState);
//            }
//            return value;
//        }

//        public virtual object ExecuteScalar()
//        {
//            if ((this.Command == null))
//            {
//                throw new ApplicationException("The command object is not defined.");
//            }
//            if ((Connection == null))
//            {
//                throw new ApplicationException("Call CreateConnection method before using the connection.");
//            }
//            ConnectionState initialState = ConnectionState.Closed;
//            object value;
//            try
//            {
//                this.QuietOpen(out initialState);
//                value = this.Command.ExecuteScalar();
//            }
//            catch (System.Exception)
//            {
//                throw;
//            }
//            finally
//            {
//                this.QuietClose(initialState);
//            }
//            return value;
//        }

//        public virtual XmlReader ExecuteXmlReader()
//        {
//            if ((this.Command == null))
//            {
//                throw new ApplicationException("The command object is not defined.");
//            }
//            if ((Connection == null))
//            {
//                throw new ApplicationException("Call CreateConnection method before using the connection.");
//            }
//            ConnectionState initialState = ConnectionState.Closed;
//            XmlReader value;
//            try
//            {
//                this.QuietOpen(out initialState);
//                value = this.Command.ExecuteXmlReader();
//            }
//            catch (System.Exception)
//            {
//                throw;
//            }
//            finally
//            {
//                this.QuietClose(initialState);
//            }
//            return value;
//        }

//        public virtual void BeginTransaction()
//        {
//            if ((CurrentTransaction != null))
//            {
//                throw new ApplicationException("There is already a pending transaction. Can not start another one.");
//            }
//            if ((Connection == null))
//            {
//                throw new ApplicationException("Call CreateConnection method before using the connection.");
//            }
//            ConnectionState initialState;
//            try
//            {
//                this.QuietOpen(out initialState);
//                CurrentTransaction = Connection.BeginTransaction();
//            }
//            catch (System.Exception)
//            {
//                throw;
//            }
//        }

//        public virtual void RollbackTransaction()
//        {
//            if ((CurrentTransaction != null))
//            {
//                CurrentTransaction.Rollback();
//                this.QuietClose(ConnectionState.Closed);
//                CurrentTransaction.Dispose();
//            }
//            else
//            {
//                throw new ApplicationException("No transaction to Rollback.");
//            }
//        }

//        public virtual void CommitTransaction()
//        {
//            if ((CurrentTransaction != null))
//            {
//                CurrentTransaction.Commit();
//                this.QuietClose(ConnectionState.Closed);
//                CurrentTransaction.Dispose();
//            }
//            else
//            {
//                throw new ApplicationException("No transaction to Commit.");
//            }
//        }

//        public virtual void Dispose()
//        {
//            if ((this.Command != null))
//            {
//                this.Command.Dispose();
//            }
//            if ((CurrentTransaction != null))
//            {
//                CurrentTransaction.Rollback();
//                CurrentTransaction.Dispose();
//            }
//            if ((Connection != null))
//            {
//                Connection.Dispose();
//            }
//        }

//        public virtual void _Dispose()
//        {
//            if ((this.Command != null))
//            {
//                this.Command.Dispose();
//            }
//            if ((CurrentTransaction != null))
//            {
//                CurrentTransaction.Dispose();
//            }
//            if ((Connection != null))
//            {
//                Connection.Dispose();
//            }
//        }

//        private void QuietOpen(out ConnectionState initialState)
//        {
//            initialState = ConnectionState.Open;
//            if ((this.Connection.State == ConnectionState.Closed))
//            {
//                initialState = ConnectionState.Closed;
//                this.Connection.Open();
//            }
//        }

//        private void QuietClose(ConnectionState initialState)
//        {
//            if ((initialState == ConnectionState.Closed))
//            {
//                this.Connection.Close();
//            }
//        }

//        private object GetValue(object value)
//        {
//            if ((value == null))
//            {
//                return DBNull.Value;
//            }
//            if (((value.GetType() == typeof(byte))
//                        && (((byte)(value)) == byte.MinValue)))
//            {
//                return DBNull.Value;
//            }
//            if (((value.GetType() == typeof(char))
//                        && (((char)(value)) == char.MinValue)))
//            {
//                return DBNull.Value;
//            }
//            if (((value.GetType() == typeof(decimal))
//                        && (((decimal)(value)) == decimal.MinValue)))
//            {
//                return DBNull.Value;
//            }
//            if (((value.GetType() == typeof(double))
//                        && (((double)(value)) == double.MinValue)))
//            {
//                return DBNull.Value;
//            }
//            if (((value.GetType() == typeof(float))
//                        && (((float)(value)) == float.MinValue)))
//            {
//                return DBNull.Value;
//            }
//            if (((value.GetType() == typeof(int))
//                        && (((int)(value)) == int.MinValue)))
//            {
//                return DBNull.Value;
//            }
//            if (((value.GetType() == typeof(long))
//                        && (((long)(value)) == long.MinValue)))
//            {
//                return DBNull.Value;
//            }
//            if (((value.GetType() == typeof(short))
//                        && (((short)(value)) == short.MinValue)))
//            {
//                return DBNull.Value;
//            }
//            if (((value.GetType() == typeof(string))
//                        && (((string)(value)) == string.Empty)))
//            {
//                return DBNull.Value;
//            }
//            if (((value.GetType() == typeof(System.DateTime))
//                        && (((System.DateTime)(value)) == System.DateTime.MinValue)))
//            {
//                return DBNull.Value;
//            }
//            if (((value.GetType() == typeof(System.Guid))
//                        && (((System.Guid)(value)) == System.Guid.Empty)))
//            {
//                return DBNull.Value;
//            }
//            return value;
//        }

//        public string GetFieldValue(string AField, string AKeyField, string ATable, string AKeyVal, string AFilter)
//        {
//            string cSQL, cResult;
//            cResult = "";
//            try
//            {
//                cSQL = " SELECT " + AField + " FROM " + ATable + " WHERE " + AKeyField + "=" + AKeyVal;
//                if (AFilter.Length > 0)
//                {
//                    cSQL = cSQL + " AND " + AFilter;
//                }
//                SqlDataAdapter sqlDA = new SqlDataAdapter(cSQL, this.Connection);
//                DataSet dataSet = new DataSet();
//                sqlDA.Fill(dataSet);
//                if (dataSet.Tables[0].Rows.Count != 0)
//                {
//                    foreach (DataRow dataRow in dataSet.Tables[0].Rows)
//                    {
//                        if (dataRow[0].ToString().Length > 0)
//                            cResult = dataRow[0].ToString();
//                    }
//                }
//            }
//            catch (Exception)
//            {
//                throw;
//            }
//            return cResult;
//        }



//    }

//}
