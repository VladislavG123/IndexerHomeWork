using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerHomeWork
{
    class Indexer
    {
        int _size;
        int[] _data;
        public Indexer(int arraySize)
        {
            _size = arraySize;
            _data = new int[_size];
        }
        public int this[int index]
        {
            get { return _data[index]; }
            set { _data[index] = value * 2; }
        }
    }
}
