using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSU2_Laboration1_AAAV.DataLayer
{
    //-----------------------------------------------------------------------------------------------------------------------
    //Generic Repository which means it connects to all enteties so you dont need make one repository per entity!
    //-----------------------------------------------------------------------------------------------------------------------
    public class Repository<T> where T : class
    {
        private readonly List<T> data;

        public Repository(List<T> data)
        {
            this.data = data;
        }

        public DataLayer.UnitOfWork UnitOfWork
        {
            get => default;
            set
            {
            }
        }

        public void Add(T entity)
        {
            data.Add(entity);
        }

        public bool Remove(T entity)
        {
            return data.Remove(entity);
        }

        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return data.Where(predicate);
        }

        public T FirstOrDefault(Func<T, bool> predicate)
        {
            return data.FirstOrDefault(predicate);
        }

        public bool IsEmpty()
        {
            return data.Count == 0;
        }

        public int Count()
        {
            return data.Count();
        }
    }
}
