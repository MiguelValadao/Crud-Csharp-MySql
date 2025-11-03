using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAppEscola
{
    internal class ConexaoAluno
    {
        MySqlConnection conn;

        public void connectDB()
        {
            try
            {
                conn = new MySqlConnection("Persist Security info = false; server = Localhost; database = db_Escola; user = root; pwd = ;");
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar ao banco de dados" + ex.Message);
            }
        }
        public void executarComandos(string sql)
        {
            try { 
               // Primeiro é necessário conectar o banco
                connectDB();
                // Classe para executar comandos
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            { 
                throw new Exception("Erro ao executar o comando: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable ExecutarConsulta(string sql)
        {
            try
            {
                // Abrir a conexão
                connectDB();
                MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao executar a consulta " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
