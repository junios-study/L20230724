using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L20230724
{
    class Component
    {
        public Component() { }
        //public Component(GameObject owner) { gameObject = owner; }
        ~Component() { }

        public GameObject gameObject; //나를 가지고 있는 게임 오브젝트는 누구인가?

        public virtual void Start()
        {

        }

        public virtual void Update()
        {
        }
    }
}
