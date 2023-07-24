using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230724
{
    class FlatEngine
    {
        public FlatEngine()
        {
            gameObjects = new List<GameObject>();

        }

        ~FlatEngine()
        {
            gameObjects.Clear();
        }

        List<GameObject> gameObjects;

        public void Instantiate(GameObject newGameObject)
        {
            gameObjects.Add(newGameObject);
        }

        public void Destroy(GameObject removeGameObject) 
        {
            gameObjects.Remove(removeGameObject);
        }

        public void Run()
        {
            while(true)
            {
                break;
            }
        }
    }
}
