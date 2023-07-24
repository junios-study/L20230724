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

           
            GameObject wall = new GameObject();
            wall.name = "Wall";
            wall.AddComponent(new Renderer());

            myEngine.Instantiate(wall);

            myEngine.Run();
        }
    }
}
