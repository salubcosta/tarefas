using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefas.Inteface
{
    /*
     * Interface IDAO é uma interface tipada. 
     * Este T irá representar todas as outras classes
     * sendo portanto modelo para todas as classes DAO
     */
    public interface IDAO<T>:IDisposable
        where T: class, new()
    {
        /*
         * Método responsável por persistir os dados
         * Este método irá apontar corretamente para
         * um insert ou um update
         */
        T save(T model);

        //Método para inserir
        T insert(T model);

        //Método para atualizar
        T update(T model);

        //Esse método é para buscar por id
        T findById(params Object[] key);

        //Método busca por nome/descricao
        IEnumerable<T> findByName(params Object[] name);

        //Método retorna todos os registros
        IEnumerable<T> findAll();
    }
}
