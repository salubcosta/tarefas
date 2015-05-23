using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;


namespace Tarefas.Inteface
{
    public interface IConexao:IDisposable
    {
        //Método para abrir conexão
        SqlConnection abrirConexao();
        
        //Método para buscar conexão já aberta
        SqlConnection buscarConexao();
        
        //Método para fechar conexão
        void fechar();
    }
}
