using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Tarefas.Inteface;
using System.Configuration;

namespace Tarefas.Classes
{
    public class Conexao:IConexao
    {
        //Pega ConnectionString do arquivo Web.config.
        private string _strCon = ConfigurationManager.ConnectionStrings["conexaoDB"].ConnectionString;
        private SqlConnection con;

        //Inicializa a classe instanciando a con
        public Conexao()
        {
            this.con = new SqlConnection(this._strCon);
        }

        //Abre a conexão
        public SqlConnection abrirConexao()
        {
            if (this.con.State == ConnectionState.Closed)
            {
                try
                {
                    this.con.Open();
                }
                catch (Exception e)
                {
                    throw new Exception("Ocorreu um erro ao tentar abrir a conexão. \nDetalhe do erro: " + e.Message);
                }
            }
            return this.con;
        }

        //Busca a conexão aberta
        public SqlConnection buscarConexao()
        {
            return this.abrirConexao();
        }

        //Fecha conexão se estiver aberta
        public void fechar()
        {
            if (this.con.State == ConnectionState.Open)
                con.Close();
        }

        /*
         * GC - Garbage Colletor é acionado com termina uma using(){}. Libera memório no servidor de DB
         */
        public void Dispose()
        {
            this.fechar();
            GC.SuppressFinalize(this);
        }
    }
}