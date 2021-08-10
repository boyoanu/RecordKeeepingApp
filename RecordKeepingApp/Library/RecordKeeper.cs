using System;
using System.Collections.Generic;
using System.Text;

namespace RecordKeepingApp.Library
{
    class RecordKeeper<T1, T2> : IRecordKeeper<T1, T2>
    {
        private readonly Dictionary<T1, T2> _dataStore; 


        public RecordKeeper()
        {
            _dataStore = new Dictionary<T1, T2>();
        }


        public int Count 
        {
            get => _dataStore.Count;
        }


        public void AcceptItem(T1 key, T2 value)
        {
            _dataStore.Add(key, value);
        }


        public List<T2> FetchAll()
        {
            return new List<T2>(_dataStore.Values);
        }


        public T2 FetchOne(T1 key)
        {
           return _dataStore[key];
        }


        public bool FetchOne(T1 key, out T2 result)
        {
            return _dataStore.TryGetValue(key, out result);
        }
    }
}
