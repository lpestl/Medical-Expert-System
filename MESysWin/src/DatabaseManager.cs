using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MESysWin.src
{
    class DatabaseManager
    {
        // Реализация паттерна Singletone
        private static DatabaseManager instance;

        private DatabaseManager() {            
            // Проверим папку DATA
            checkDataDir();
            // Проверим файл базы данных
            if (!File.Exists(DatabaseName))
            {
                // Если не существует, то сообщим, что создадим новую.
                Log.Print("Knowledge base and database do not exist. A new database file is created in \"" + DatabaseName + "\" the path.", "DatabaseManager", Log.type.WARNING);
                MessageBox.Show("Knowledge base and database do not exist. A new database file is created in \"" + DatabaseName + "\" the path.", "Database not exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Строка подключения к базе данных
            connection_string = "Data Source="
                + DatabaseName
                + ";";

            //conn = new SQLiteConnection(connection_string);
        }
        
        public static DatabaseManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseManager();
                    Log.Print("Create DatabaseManager instance singletone", "DatabaseManager", Log.type.INFO);
                }
                return instance;
            }
        }

        // Имя базы данных
        // KBofMD - Knowledge base of medical diagnosis
        private string database_name = "data\\KBofMD.db";
        public string DatabaseName
        {
            get { return database_name; }
        }

        // Проверка наличия папки DATA
        private bool checkDataDir()
        {
            if (!Directory.Exists("data"))
            {
                try
                {
                    Directory.CreateDirectory("data");
                    Log.Print("Create directory DATA", "DatabaseManager", Log.type.INFO);

                    return true;
                }
                catch (Exception ex)
                {
                    Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            } else
            {
                return true;
            }
        }

        private string connection_string;
        private SQLiteConnection conn;

        private void OpenConnection()
        {
            conn = new SQLiteConnection(connection_string);

            try
            {
                // Подключаемся
                conn.Open();
                //Log.Print("Open connection database", "DatabaseManager", Log.type.INFO);
            }
            catch (SQLiteException ex)
            {
                // Сообщаем об ощибке подключения
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateTables()
        {
            // Если подключение есть
            if (conn.State == ConnectionState.Open)
            {
                // Создадим таблицу Linguistic_variable, если она не существует
                CreateTable(conn, "linguistic_variable",
                    "id_ling_var INTEGER PRIMARY KEY AUTOINCREMENT",
                    "name TEXT NOT NULL",
                    "reasoning_bottom REAL NOT NULL",
                    "reasoning_top REAL NOT NULL");

                // Создадим таблицу MF_type, если она не существует
                CreateTable(conn, "mf_type",
                    "id_mf_type INTEGER PRIMARY KEY",
                    "name TEXT NOT NULL",
                    "description TEXT");

                // Создадим таблицу Triangular_MF, если она не существует
                CreateTable(conn, "triangular_mf",
                    "id_triangl_mf INTEGER PRIMARY KEY AUTOINCREMENT",
                    //"id_mf_type INTEGER NOT NULL",
                    "a REAL NOT NULL",
                    "b REAL NOT NULL",
                    "c REAL NOT NULL");

                // Создадим таблицу Trapezoidal_MF, если она не существует
                CreateTable(conn, "trapezoidal_mf",
                    "id_trapez_mf INTEGER PRIMARY KEY AUTOINCREMENT",
                    //"id_mf_type INTEGER NOT NULL",
                    "a REAL NOT NULL",
                    "b REAL NOT NULL",
                    "c REAL NOT NULL",
                    "d REAL NOT NULL");

                // Создадим таблицу Gauss_MF, если она не существует
                CreateTable(conn, "gauss_mf",
                    "id_gauss_mf INTEGER PRIMARY KEY AUTOINCREMENT",
                    //"id_mf_type INTEGER NOT NULL",
                    "c REAL NOT NULL",
                    "q REAL NOT NULL");

                // Создадим таблицу Fuzzy_variable, если она не существует
                CreateTable(conn, "fuzzy_variable",
                    "id_var INTEGER PRIMARY KEY AUTOINCREMENT",
                    "id_ling_var INTEGER NOT NULL",
                    "name TEXT NOT NULL",
                    "id_mf_type INTEGER",
                    "id_triangl_mf INTEGER",
                    "id_trapez_mf INTEGER",
                    "id_gauss_mf INTEGER",
                    "r INTEGER",
                    "g INTEGER",
                    "b INTEGER",
                    "FOREIGN KEY (id_ling_var) REFERENCES linguistic_variable(id_ling_var)",
                    "FOREIGN KEY (id_mf_type) REFERENCES mf_type(id_mf_type)",
                    "FOREIGN KEY (id_triangl_mf) REFERENCES triangular_mf(id_triangl_mf)",
                    "FOREIGN KEY (id_trapez_mf) REFERENCES trapezoidal_mf(id_trapez_mf)",
                    "FOREIGN KEY (id_gauss_mf) REFERENCES gauss_mf(id_gauss_mf)");
            }
        }

        private void CloseConnection()
        {
            try
            {
                // Закрываем подключение
                conn.Dispose();
                //conn.Close();
                conn = null;
            } catch (SQLiteException ex)
            {
                // Сообщаем об ощибке отключения
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        // Первое подключение к базе данных
        public void DatabaseConnect()
        {
            OpenConnection();
            CreateTables();
            CloseConnection();
        }
                
        private void CreateTable(SQLiteConnection SQLiteCon, string name_table, params string[] fields)
        {
            SQLiteCommand cmd = SQLiteCon.CreateCommand();

            string sql_command = "CREATE table IF NOT EXISTS " + name_table + " (";
            for (int i = 0; i < fields.Length; i++)
            {
                sql_command += fields[i];
                if ((i+1) < fields.Length)
                {
                    sql_command += ", ";
                } else
                {
                    sql_command += ");";
                }
            }

            cmd.CommandText = sql_command;
            try
            {
                cmd.ExecuteNonQuery();
                //Log.Print("CREATE table IF NOT EXISTS " + name_table, "DatabaseManager", Log.type.INFO);
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                //MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        // Вернуть список всех симптомов и их ID
        public List<Symptom> GetSymptomList()
        {
            List<Symptom> res = new List<Symptom>();

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT id_ling_var, name, reasoning_bottom, reasoning_top "
                + "FROM linguistic_variable";

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    res.Add(new Symptom(r.GetInt64(0), r.GetString(1), r.GetDouble(2), r.GetDouble(3)));
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
            }

            CloseConnection();

            return res;
        }

        public List<TypeMFunc> GetTypesMf()
        {
            List<TypeMFunc> list = new List<TypeMFunc>();

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT id_mf_type, name, description FROM mf_type";
            
            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();
                    
                while (r.Read())
                {
                    list.Add(new TypeMFunc(r.GetInt64(0), r.GetString(1), r.GetString(2)));
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
            }

            CloseConnection();

            return list;
        }

        public List<FuzzyVariable> GetFuzzyVariables(long id_symptom)
        {
            List<FuzzyVariable> reslist = new List<FuzzyVariable>();
            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "SELECT "
                    + "id_var, "
                    + "id_ling_var, "
                    + "name, "
                    + "id_mf_type, "
                    + "id_triangl_mf, "
                    + "id_trapez_mf, "
                    + "id_gauss_mf, "
                    + "r, g, b "
                + "FROM fuzzy_variable "
                + "WHERE id_ling_var = @id_ling_var";

            cmd.Parameters.AddWithValue("@id_ling_var", id_symptom);

            try
            {
                SQLiteDataReader r = cmd.ExecuteReader();

                while (r.Read())
                {
                    System.Drawing.Color clr = new System.Drawing.Color();
                    try
                    {
                        clr = System.Drawing.Color.FromArgb(r.GetInt32(7), r.GetInt32(8), r.GetInt32(9));
                    } catch
                    {
                        clr = System.Drawing.Color.Yellow;
                    }

                    FuzzyVariable fv;
                    try
                    {
                        fv = new FuzzyVariable(r.GetInt64(0), r.GetInt64(1), r.GetString(2), clr);
                    } catch
                    {
                        fv = new FuzzyVariable(r.GetInt64(0), r.GetInt64(1), "", clr);
                    }

                    //fv.ID = r.GetInt64(0);
                    
                    switch(r.GetInt64(3))
                    {
                        case 0:
                            fv.Type = TypeMFuncEnum.GAUSS;
                            break;
                        case 1:
                            fv.Type = TypeMFuncEnum.TRIANGULARE;
                            break;
                        case 2:
                            fv.Type = TypeMFuncEnum.TRAPEZOIDAL;
                            break;
                        default:
                            fv.Type = TypeMFuncEnum.NOT_SETUP;
                            break; 
                    }

                    fv.Color = clr;

                    try { fv.IdTriangulare = r.GetInt64(4); } catch { fv.IdTriangulare = -1; }
                    try { fv.IdTrapezoidal = r.GetInt64(5); } catch { fv.IdTrapezoidal = -1; }
                    try { fv.IdGaussian = r.GetInt64(6); } catch { fv.IdGaussian = -1; }

                    reslist.Add(fv);
                }
                r.Close();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
            }

            CloseConnection();
            return reslist;
        }
        
        public bool DeleteFromTable(long id, string tableName, string columnName)
        {
            bool res = false;
            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = String.Format("DELETE FROM {0} WHERE {1} = '{2}'", 
                tableName, columnName, id);
                
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
            return res;
        }

        public int GetMaxId(string table, string colunmId)
        {
            int res = -1;

            OpenConnection();
            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = String.Format("SELECT max({0}) FROM {1}", colunmId, table);

            try
            {
                var obj = cmd.ExecuteScalar();
                res = Convert.ToInt32(obj);
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
            return res;
        }

        public void InsertType(TypeMFunc type)
        {
            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO mf_type "
                + "(id_mf_type, name, description) "
                + "VALUES (@id_mf_type, @name, @description)";

            cmd.Parameters.AddWithValue("@id_mf_type", type.ID);
            cmd.Parameters.AddWithValue("@name", type.Name);
            cmd.Parameters.AddWithValue("@description", type.Description);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
        }

        public void UpdateType(TypeMFunc type)
        {
            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "UPDATE mf_type "
                + "SET name = @name, description = @description "
                + "WHERE id_mf_type = @id_mf_type";

            cmd.Parameters.AddWithValue("@id_mf_type", type.ID);
            cmd.Parameters.AddWithValue("@name", type.Name);
            cmd.Parameters.AddWithValue("@description", type.Description);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
        }

        public long InsertSymptom(Symptom smp)
        {
            long inserted_id = -1;

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO linguistic_variable "
                + "(name, reasoning_bottom, reasoning_top) "
                + "VALUES (@name, @reasoning_bottom, @reasoning_top)";

            cmd.Parameters.AddWithValue("@name", smp.Name);
            cmd.Parameters.AddWithValue("@reasoning_bottom", smp.ReasoningBottom);
            cmd.Parameters.AddWithValue("@reasoning_top", smp.ReasoningTop);

            try
            {
                cmd.ExecuteNonQuery();
                
                inserted_id = conn.LastInsertRowId;
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return inserted_id;
        }

        public void UpdateSymptome(Symptom smp)
        {
            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "UPDATE linguistic_variable "
                + "SET name = @name, "
                + "reasoning_bottom = @reasoning_bottom, "
                + "reasoning_top = @reasoning_top "
                + "WHERE id_ling_var = @id_ling_var";

            cmd.Parameters.AddWithValue("@id_ling_var", smp.ID);
            cmd.Parameters.AddWithValue("@name", smp.Name);
            cmd.Parameters.AddWithValue("@reasoning_bottom", smp.ReasoningBottom);
            cmd.Parameters.AddWithValue("@reasoning_top", smp.ReasoningTop);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();
        }
        
        public long InsertMF(double c, double sigma)
        {
            long inserted_id = -1;

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO gauss_mf "
                + "(c, q) "
                + "VALUES (@c, @q)";

            cmd.Parameters.AddWithValue("@c", c);
            cmd.Parameters.AddWithValue("@q", sigma);

            try
            {
                cmd.ExecuteNonQuery();
                
                inserted_id = conn.LastInsertRowId;
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return inserted_id;
        }

        public long InsertMF(double a, double b, double c)
        {
            long inserted_id = -1;

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO triangular_mf "
                + "(a, b, c) "
                + "VALUES (@a, @b, @c)";

            cmd.Parameters.AddWithValue("@a", a);
            cmd.Parameters.AddWithValue("@b", b);
            cmd.Parameters.AddWithValue("@c", c);

            try
            {
                cmd.ExecuteNonQuery();

                inserted_id = conn.LastInsertRowId;
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return inserted_id;
        }

        public long InsertMF(double a, double b, double c, double d)
        {
            long inserted_id = -1;

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO trapezoidal_mf "
                + "(a, b, c, d) "
                + "VALUES (@a, @b, @c, @d)";

            cmd.Parameters.AddWithValue("@a", a);
            cmd.Parameters.AddWithValue("@b", b);
            cmd.Parameters.AddWithValue("@c", c);
            cmd.Parameters.AddWithValue("@d", d);

            try
            {
                cmd.ExecuteNonQuery();

                inserted_id = conn.LastInsertRowId;
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return inserted_id;
        }

        public long InsertFuzzyVar(FuzzyVariable fv)
        {
            long inserted_id = -1;

            OpenConnection();

            SQLiteCommand cmd = conn.CreateCommand();

            cmd.CommandText = "INSERT INTO fuzzy_variable "
                + "(id_ling_var, name, id_mf_type, id_triangl_mf, id_trapez_mf, "
                + "id_gauss_mf, r, g, b) "
                + "VALUES (@id_ling_var, @name, @id_mf_type, @id_triangl_mf, @id_trapez_mf, "
                + "@id_gauss_mf, @r, @g, @b)";

            cmd.Parameters.AddWithValue("@id_ling_var", fv.IdSymptom);
            cmd.Parameters.AddWithValue("@name", fv.Name);
            cmd.Parameters.AddWithValue("@id_mf_type", (int)fv.Type);
            cmd.Parameters.AddWithValue("@id_triangl_mf", fv.IdTriangulare);
            cmd.Parameters.AddWithValue("@id_trapez_mf", fv.IdTrapezoidal);
            cmd.Parameters.AddWithValue("@id_gauss_mf", fv.IdGaussian);
            cmd.Parameters.AddWithValue("@r", fv.Color.R);
            cmd.Parameters.AddWithValue("@g", fv.Color.G);
            cmd.Parameters.AddWithValue("@b", fv.Color.B);

            try
            {
                cmd.ExecuteNonQuery();

                inserted_id = conn.LastInsertRowId;
            }
            catch (SQLiteException ex)
            {
                Log.Print(ex.Message, ex.Source, Log.type.ERROR);
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CloseConnection();

            return inserted_id;
        }
    }
}
