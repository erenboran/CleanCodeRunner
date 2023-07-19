using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyProject2.Abstract.Utilities
{
    public abstract class SingletonMonoBeheviorObject<T> : MonoBehaviour where T : Component
    {
        public static T Instance { get; private set; }
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }


    }
}
