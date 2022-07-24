using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS
{
    class GenericDAO<T,I> : IGenericDAO<T,I> 
        where T : IHasId<I>
        where I : IComparable<int>, IConvertible
    {
        private List<T> myList = new List<T>();
        public bool Delete(T t)
        {
           return myList.Remove(t);
        }

        public T Get(int id) 
        {
            return myList.Where(x => id.CompareTo(x.Id) == 0).FirstOrDefault();
        }

        public T Get(Func<T, int, bool> predect)
        {
            return myList.Where(predect).FirstOrDefault();
        }

        public List<T> GetAll(Func<T,bool> predect)
        {
            return myList.Where(predect).ToList();
        }

        public List<T> GetAll()
        {
            return myList.ToList();
        }

        public void Insert(T t)
        {
            myList.Add(t);
        }

        public bool Update(T t)
        {
            var Existed = Get(Convert.ToInt32(t.Id));
            if (Existed == null) return false;

            myList.Remove(Existed);
            myList.Add(t);
            return true;
        }
    }
}
