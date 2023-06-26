using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrilClinica.Entities.SQL
{
    internal interface IManagement<T>
    {
        public Task<List<T>> GetAll();
        public Task Add(T entity);
        public Task Update(T entity);
        public Task Delete(int id);

    }
}
