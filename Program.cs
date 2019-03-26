using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Indexer indexer = new Indexer(10);

            indexer[1] = 2;
            Console.WriteLine(indexer[1]);
            Console.Read();
        }
    }
}
