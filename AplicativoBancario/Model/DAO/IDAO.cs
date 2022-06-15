using System.Collections.Generic;

namespace AplicativoBancario.Model.DAO
{
    internal interface IDAO<T>
    {
        public void Adicionar(T obj);
        public void Deletar(int id);
        public T ConcultarPorId(int id);
        public List<T> ConsultarTodos();
        public void Editar(T obj);
    }
}
