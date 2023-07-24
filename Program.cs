using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230724
{
    class Program
    {
        static void Main(string[] args)
        {
            FlatEngine myEngine = new FlatEngine();

            myEngine.Instantiate(new GameObject());

            myEngine.Run();
        }
    }
}
