using System;
using System.Collections;
using System.Threading.Tasks;

namespace MasteringCSharp.HashMap
{
    public class HashMap<TKey, TValue> : IHashMap<TKey, TValue>, ICollection
    {
        public HashMap()
        {
        }

        public int Count => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public TValue Get(TKey key)
        {
            throw new NotImplementedException();
        }

        public Task<TValue> GetAsync(TKey key)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Set(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }

        public Task SetAsync(TKey key, TValue value)
        {
            throw new NotImplementedException();
        }
    }
}
