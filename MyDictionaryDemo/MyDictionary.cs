﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemo
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] keys;
        TValue[] values;
        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] tempArray1 = keys;
            TValue[] tempArray2 = values;
            keys = new TKey[keys.Length + 1];
            values = new TValue[values.Length + 1];
            for (int i = 0; i < tempArray1.Length; i++)
            {
                keys[i] = tempArray1[i];
                values[i] = tempArray2[i];

            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public int Length
        {
            get { return keys.Length; }
        }

        public TKey[] key
        {
            get { return keys; }
        }

        public TValue[] value
        {
            get { return values; }
        }
    }
}
