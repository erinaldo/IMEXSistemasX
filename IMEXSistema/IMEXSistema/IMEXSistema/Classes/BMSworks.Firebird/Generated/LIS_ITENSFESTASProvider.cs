//Template gerado utilizando o MyGeneration
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;
using System.Collections.Generic;
using FirebirdSql.Data.FirebirdClient;
using BMSSoftware;
using BMSworks.Model;
using BmsSoftware;
using BMSworks.Firebird;


namespace BMSworks.Firebird
{
	public partial class LIS_ITENSFESTASProvider 
	{
		//String de conexão recuperada do Web.Config
		private static readonly string connectionString = BmsSoftware.ConfigSistema1.Default.ConexaoFB + BmsSoftware.ConfigSistema1.Default.UrlBd;
		private FbConnection dbCnn = null;
		private FbCommand dbCommand = null;
		private FbTransaction dbTransaction = null;

		~LIS_ITENSFESTASProvider()
		{
			dbCnn = null;
			dbCommand = null;
			dbTransaction = null;
		}

		public  FbConnection GetConnectionDB()
		{
			FbConnection cnx = new FbConnection();
			cnx.ConnectionString = connectionString;
			return cnx;
		}

		public FbTransaction GetTransaction()
		{
			return dbTransaction;
		}

		public void BeginTransaction()
		{
			try
			{
				if (dbTransaction == null)
				{
					if (dbCnn == null)
						dbCnn = (FbConnection)GetConnectionDB();

					if (dbCnn.State == ConnectionState.Closed)
						dbCnn.Open();

					dbTransaction = dbCnn.BeginTransaction(IsolationLevel.ReadCommitted);

				}
			}
			catch (Exception e)
			{
				dbTransaction = null;
				throw e;
			}
		}

		public void BeginTransaction(FbTransaction _dbTransaction)
		{
			try
			{
				if (_dbTransaction != null)
				{
					dbTransaction = (FbTransaction)_dbTransaction;
					dbCnn = dbTransaction.Connection;
				}
				else
				{
					if (dbTransaction == null)
					{
						if (dbCnn == null)
							dbCnn = (FbConnection)GetConnectionDB();

						if (dbCnn.State == ConnectionState.Closed)
							dbCnn.Open();

						dbTransaction = dbCnn.BeginTransaction(IsolationLevel.ReadCommitted);

					}
				}
			}
			catch (Exception e)
			{
				dbTransaction = null;
				throw e;
			}
		}

		public void BeginTransaction(IsolationLevel NivelIsolamento)
		{
			try
			{
				if (dbTransaction == null)
				{
					if (dbCnn == null)
						dbCnn = (FbConnection)GetConnectionDB();

					if (dbCnn.State == ConnectionState.Closed)
						dbCnn.Open();

					dbTransaction = dbCnn.BeginTransaction(NivelIsolamento);

				}
			}
			catch (Exception e)
			{
				dbTransaction = null;
				throw e;
			}
		}

		public void EndTransaction()
		{
			try
			{
				// Comita a transação
				if (dbTransaction != null)
					if (dbTransaction.Connection != null)
					{
						dbTransaction.Commit();
						dbTransaction = null;
					}
			}
			catch (Exception e)
			{
				this.RollbackTransaction();
				throw e;
			}

			try
			{
				// Fecha a conexão
				if (dbCnn != null)
					if (dbCnn.State != ConnectionState.Closed)
						dbCnn.Close();
			}
			catch (Exception e)
			{
				throw e;
			}
		}

		public  void CommitTransaction()
		{
			try
			{
				if (dbTransaction != null)
				{
				if (dbTransaction.Connection != null)
					dbTransaction.Commit();

				dbTransaction = null;
				}
			}
			catch (Exception e)
			{
				this.RollbackTransaction();
				throw e;
			}
		}

		public  void RollbackTransaction()
		{
			try
			{
				if (dbTransaction != null)
					if (dbTransaction.Connection != null)
					{
						dbTransaction.Rollback();
						dbTransaction = null;
						dbCnn.Close();
					}
			}
			catch (Exception e)
			{
				throw e;
			}
		}
		
		

		public  LIS_ITENSFESTASCollection ReadCollection()
		{
			FbDataReader dataReader = null;

			try
			{
				LIS_ITENSFESTASCollection collection = null;

				//Verificando a existência de um transação aberta
				if (dbTransaction != null)
				{
					if (dbCnn.State == ConnectionState.Closed)
						dbCnn.Open();

					dbCommand = new FbCommand("SELECT * FROM LIS_ITENSFESTAS", dbCnn);
					dbCommand.Transaction = ((FbTransaction)(dbTransaction));
				}
				else
				{
					if (dbCnn == null)
						dbCnn = ((FbConnection)GetConnectionDB());

					if (dbCnn.State == ConnectionState.Closed)
						dbCnn.Open();

					dbCommand = new FbCommand("SELECT * FROM LIS_ITENSFESTAS", dbCnn);
					dbCommand.Transaction = dbCnn.BeginTransaction(IsolationLevel.ReadCommitted);
				}

				// Tipo do comando de banco Procedure ou SQL
				dbCommand.CommandType = CommandType.Text;

				collection = ExecuteReader(ref collection, ref dataReader, dbCommand);

				if(dataReader != null)
				{
					dataReader.Close();
					dataReader.Dispose();
				}

				if (dbTransaction == null)
				{
					dbCommand.Transaction.Commit();
					dbCnn.Close();
				}

				return collection;			
			}
			catch (Exception ex)
			{
				// Deleta reader
				if (dataReader != null)
				{
					dataReader.Close();
					dataReader.Dispose();
				}

				if (dbTransaction != null)
					this.RollbackTransaction();
				else
				{
					if (dbCommand.Transaction != null)
						dbCommand.Transaction.Rollback();
					if (dbCnn.State == ConnectionState.Open)
						dbCnn.Close();
				}

				throw ex;
			}
		}

		public  LIS_ITENSFESTASCollection ReadCollectionByParameter(List<RowsFiltro> RowsFiltro)
		{
			FbDataReader dataReader = null;

			try
			{
				if (RowsFiltro != null)
				{
					if (RowsFiltro.Count > 0)
					{
						LIS_ITENSFESTASCollection collection = null;

						string strSqlCommand = "SELECT * FROM LIS_ITENSFESTAS WHERE (";

						ArrayList _rowsFiltro = new ArrayList();
						RowsFiltro.ForEach(delegate(RowsFiltro i)
						{
							string[] item = { i.Condicao.ToString(), i.Campo.ToString(), i.Tipo.ToString(), i.Operador.ToString(), i.Valor.ToString() };
							_rowsFiltro.Add(item);
						});

						int _count = 1;
						foreach (string[] item in _rowsFiltro)
						{
							strSqlCommand += "(" + item[1] + " " + item[3]; 
							switch (item[2])
							{
								case ("System.String"):
									if(item[3].ToUpper() != "LIKE")
										strSqlCommand += " '" + item[4] + "')";
									else
										strSqlCommand += " '%" + item[4] + "%')";
									break;
								case ("System.Int16"):
									if (item[3].ToUpper() != "LIKE")
										strSqlCommand += " " + item[4] + ")";
									else
										strSqlCommand += " '%" + item[4] + "%')";
									break;
								case ("System.Int32"):
									if (item[3].ToUpper() != "LIKE")
										strSqlCommand += " " + item[4] + ")";
									else
										strSqlCommand += " '%" + item[4] + "%')";
									break;
								case ("System.Int64"):
									if (item[3].ToUpper() != "LIKE")
										strSqlCommand += " " + item[4] + ")";
									else
										strSqlCommand += " '%" + item[4] + "%')";
									break;
								case ("System.Double"):
									if (item[3].ToUpper() != "LIKE")
										strSqlCommand += " " + item[4] + ")";
									else
										strSqlCommand += " '%" + item[4] + "%')";
									break;
								case ("System.Decimal"):
									if (item[3].ToUpper() != "LIKE")
										strSqlCommand += " " + item[4] + ")";
									else
										strSqlCommand += " '%" + item[4] + "%')";
									break;
								case ("System.Float"):
									if (item[3].ToUpper() != "LIKE")
										strSqlCommand += " " + item[4] + ")";
									else
										strSqlCommand += " '%" + item[4] + "%')";
									break;
								case ("System.Byte"):
										strSqlCommand += " " + item[4] + ")";
									break;
								case ("System.SByte"):
									strSqlCommand += " " + item[4] + ")";
									break;
								case ("System.Char"):
									if (item[3].ToUpper() != "LIKE")
										strSqlCommand += " '" + item[4] + "')";
									else
										strSqlCommand += " '%" + item[4] + "%')";
									break;
								case ("System.DateTime"):
									if (item[3].ToUpper() != "LIKE")
										strSqlCommand += " '" + item[4] + "')";
									else
										strSqlCommand += " '%" + item[4] + "%')";
									break;
								case ("System.Guid"):
									if (item[3].ToUpper() != "LIKE")
										strSqlCommand += " '" + item[4] + "')";
									else
										strSqlCommand += " '%" + item[4] + "%')";
									break;
								case ("System.Boolean"): 
									strSqlCommand += " " + item[4] + ")"; 
								break;
							}
							if (_rowsFiltro.Count > 1) 
							{
								if (_count < _rowsFiltro.Count)
								{
									strSqlCommand += " " + item[0] + " ";
								}
								_count++;
							}
						}
						strSqlCommand += ");";

						//Verificando a existência de um transação aberta
						if (dbTransaction != null)
						{
							if (dbCnn.State == ConnectionState.Closed)
								dbCnn.Open();

							dbCommand = new FbCommand(strSqlCommand, dbCnn);
							dbCommand.CommandType = CommandType.Text;
							dbCommand.Transaction = ((FbTransaction)(dbTransaction));
						}
						else
						{
							if(dbCnn == null)
								dbCnn = new FbConnection(connectionString);

							if (dbCnn.State == ConnectionState.Closed)
								dbCnn.Open();

							dbCommand = new FbCommand(strSqlCommand, dbCnn);
							dbCommand.CommandType = CommandType.Text;
							dbCommand.Transaction = dbCnn.BeginTransaction(IsolationLevel.ReadCommitted);
						}


						collection = ExecuteReader(ref collection, ref dataReader, dbCommand);

						if(dataReader != null)
						{
							dataReader.Close();
							dataReader.Dispose();
						}

						if (dbTransaction == null)
						{
							dbCommand.Transaction.Commit();
							dbCnn.Close();
						}

						return collection;
					}
					else
					{
						return this.ReadCollection();
					}
				}
				else
				{
					return this.ReadCollection();
				}
			}
			catch (Exception ex)
			{
				// Deleta reader
				if (dataReader != null)
				{
					dataReader.Close();
					dataReader.Dispose();
				}

				if (dbTransaction != null)
					this.RollbackTransaction();
				else
				{
					if(dbCommand.Transaction != null)
						dbCommand.Transaction.Rollback();
					if (dbCnn.State == ConnectionState.Open)
						dbCnn.Close();
				}

				throw ex;
			}
		}


public  LIS_ITENSFESTASCollection ReadCollectionByParameter(List<RowsFiltro> RowsFiltro,  string FieldOrder)
		{
			FbDataReader dataReader = null;
			string strSqlCommand = String.Empty;
			LIS_ITENSFESTASCollection collection = null;
			
			try
			{
				if (RowsFiltro != null)
				{
					if (RowsFiltro.Count > 0)
					{
						

						strSqlCommand = "SELECT * FROM LIS_ITENSFESTAS WHERE (";

						ArrayList _rowsFiltro = new ArrayList();
						RowsFiltro.ForEach(delegate(RowsFiltro i)
						{
							string[] item = { i.Condicao.ToString(), i.Campo.ToString(), i.Tipo.ToString(), i.Operador.ToString(), i.Valor.ToString() };
							_rowsFiltro.Add(item);
						});

						int _count = 1;
						foreach (string[] item in _rowsFiltro)
						{
							strSqlCommand += "(" + item[1] + " " + item[3]; 
							switch (item[2])
							{
								case ("System.String"):
									if(item[3].ToUpper() != "LIKE")
										strSqlCommand += " '" + item[4] + "')";
									else
										strSqlCommand += " '%" + item[4] + "%')";
									break;
								case ("System.Int16"):
									if (item[3].ToUpper() != "LIKE")
										strSqlCommand += " " + item[4] + ")";
									else
										strSqlCommand += " '%" + item[4] + "%')";
									break;
								case ("System.Int32"):
									if (item[3].ToUpper() != "LIKE")
										strSqlCommand += " " + item[4] + ")";
									else
										strSqlCommand += " '%" + item[4] + "%')";
									break;
								case ("System.Int64"):
									if (item[3].ToUpper() != "LIKE")
										strSqlCommand += " " + item[4] + ")";
									else
										strSqlCommand += " '%" + item[4] + "%')";
									break;
								case ("System.Double"):
									if (item[3].ToUpper() != "LIKE")
										strSqlCommand += " " + item[4] + ")";
									else
										strSqlCommand += " '%" + item[4] + "%')";
									break;
								case ("System.Decimal"):
									if (item[3].ToUpper() != "LIKE")
										strSqlCommand += " " + item[4] + ")";
									else
										strSqlCommand += " '%" + item[4] + "%')";
									break;
								case ("System.Float"):
									if (item[3].ToUpper() != "LIKE")
										strSqlCommand += " " + item[4] + ")";
									else
										strSqlCommand += " '%" + item[4] + "%')";
									break;
								case ("System.Byte"):
										strSqlCommand += " " + item[4] + ")";
									break;
								case ("System.SByte"):
									strSqlCommand += " " + item[4] + ")";
									break;
								case ("System.Char"):
									if (item[3].ToUpper() != "LIKE")
										strSqlCommand += " '" + item[4] + "')";
									else
										strSqlCommand += " '%" + item[4] + "%')";
									break;
								case ("System.DateTime"):
									if (item[3].ToUpper() != "LIKE")
										strSqlCommand += " '" + item[4] + "')";
									else
										strSqlCommand += " '%" + item[4] + "%')";
									break;
								case ("System.Guid"):
									if (item[3].ToUpper() != "LIKE")
										strSqlCommand += " '" + item[4] + "')";
									else
										strSqlCommand += " '%" + item[4] + "%')";
									break;
								case ("System.Boolean"): 
									strSqlCommand += " " + item[4] + ")"; 
								break;
							}
							if (_rowsFiltro.Count > 1) 
							{
								if (_count < _rowsFiltro.Count)
								{
									strSqlCommand += " " + item[0] + " ";
								}
								_count++;
							}
						}
						strSqlCommand += ") order by  " + FieldOrder;

						
					}
					else
					{
						strSqlCommand = "SELECT * FROM LIS_ITENSFESTAS  order by  " + FieldOrder;
					}
				}
				else
				{
					strSqlCommand = "SELECT * FROM LIS_ITENSFESTAS order by  " + FieldOrder;
				}
				
				//Verificando a existência de um transação aberta
						if (dbTransaction != null)
						{
							if (dbCnn.State == ConnectionState.Closed)
								dbCnn.Open();

							dbCommand = new FbCommand(strSqlCommand, dbCnn);
							dbCommand.CommandType = CommandType.Text;
							dbCommand.Transaction = ((FbTransaction)(dbTransaction));
						}
						else
						{
							if(dbCnn == null)
								dbCnn = new FbConnection(connectionString);

							if (dbCnn.State == ConnectionState.Closed)
								dbCnn.Open();

							dbCommand = new FbCommand(strSqlCommand, dbCnn);
							dbCommand.CommandType = CommandType.Text;
							dbCommand.Transaction = dbCnn.BeginTransaction(IsolationLevel.ReadCommitted);
						}


						collection = ExecuteReader(ref collection, ref dataReader, dbCommand);

						if(dataReader != null)
						{
							dataReader.Close();
							dataReader.Dispose();
						}

						if (dbTransaction == null)
						{
							dbCommand.Transaction.Commit();
							dbCnn.Close();
						}

						return collection;
				
				
			}
			catch (Exception ex)
			{
				// Deleta reader
				if (dataReader != null)
				{
					dataReader.Close();
					dataReader.Dispose();
				}

				if (dbTransaction != null)
					this.RollbackTransaction();
				else
				{
					if(dbCommand.Transaction != null)
						dbCommand.Transaction.Rollback();
					if (dbCnn.State == ConnectionState.Open)
						dbCnn.Close();
				}

				throw ex;
			}
		}


		private static LIS_ITENSFESTASCollection ExecuteReader(ref LIS_ITENSFESTASCollection collection, ref FbDataReader dataReader, FbCommand dbCommand)
		{
			using (dataReader = dbCommand.ExecuteReader())
			{
				collection = new LIS_ITENSFESTASCollection();

				if (dataReader.HasRows)
				{
					while (dataReader.Read())
					{
						collection.Add(FillEntityObject(ref dataReader));
					}
				}

				if (!(dataReader.IsClosed))
				{
					dataReader.Close();
				}
				dataReader.Dispose();
			}

			return collection;
		}

		private static LIS_ITENSFESTASEntity FillEntityObject(ref FbDataReader DataReader) 
		{
			LIS_ITENSFESTASEntity entity = new LIS_ITENSFESTASEntity();

			FirebirdGetDbData getData = new FirebirdGetDbData();

						entity.IDITENSFESTAS = getData.ConvertDBValueToInt32(DataReader, DataReader.GetOrdinal("IDITENSFESTAS"));
			entity.IDFESTA = getData.ConvertDBValueToInt32(DataReader, DataReader.GetOrdinal("IDFESTA"));
			entity.NOMEFESTA = getData.ConvertDBValueToStringNullable(DataReader, DataReader.GetOrdinal("NOMEFESTA"));
			entity.OBSERVACAO = getData.ConvertDBValueToStringNullable(DataReader, DataReader.GetOrdinal("OBSERVACAO"));
			entity.TOTALITENS = getData.ConvertDBValueToDecimalNullable(DataReader, DataReader.GetOrdinal("TOTALITENS"));


			return entity;
		}
	}
}
	