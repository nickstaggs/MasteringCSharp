using System;
using System.Threading.Tasks;

namespace MasteringCSharp.HashMap
{
    public interface IHashMap<TKey, TValue>
    {
        TValue Get(TKey key);
        void Set(TKey key, TValue value);
        Task<TValue> GetAsync(TKey key);
        Task SetAsync(TKey key, TValue value);

    }
}
