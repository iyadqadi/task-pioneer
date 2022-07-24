using System;
using System.Collections.Generic;
using System.Text;

namespace POS
{
    public interface IHasId <I>
    {
        public I Id { get; set; }
    }
    public interface IGenericDAO<T,I> 
        where T : IHasId<I>
        where I : IComparable<int> , IConvertible
    {
        public List<T> GetAll();
        public List<T> GetAll(Func<T, bool> predect);
        public void Insert(T t);
        public T Get(int id);
        public T Get(Func<T, int, bool> predect);
        public bool Update(T t);
        public bool Delete(T t);
    }
}
