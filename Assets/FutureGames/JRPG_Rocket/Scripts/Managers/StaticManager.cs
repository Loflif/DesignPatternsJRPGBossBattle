using System;
using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    public abstract class StaticManager<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T actualInstance;

        //Return instance of manager if instance exists
        //Otherwise attempt to find instance
        //If instance cannot be found in scene, create new one
        public static T Instance
        {
            get
            {
                if (actualInstance != null)
                    return actualInstance;
                actualInstance = FindObjectOfType<T>();

                if (actualInstance == null)
                {
                    actualInstance = CreateManager();
                }
                return actualInstance;
            }
        }
        
        //Create new gameObject and attach manager to it
        //Return manager
        private static T CreateManager()
        {
            GameObject managerParent = new GameObject($"{typeof(T).Name}");
            T          instance      = managerParent.AddComponent<T>();
            DontDestroyOnLoad(managerParent);
            return instance;
        }
    }
}