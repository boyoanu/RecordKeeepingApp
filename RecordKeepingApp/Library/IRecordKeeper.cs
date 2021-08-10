using System;
using System.Collections.Generic;
using System.Text;

namespace RecordKeepingApp.Library
{
    interface IRecordKeeper<T1, T2>
    {

        void AcceptItem(T1 key, T2 value);


        T2 FetchOne(T1 key);


        List<T2> FetchAll();


        int Count { get; }
    }
}
