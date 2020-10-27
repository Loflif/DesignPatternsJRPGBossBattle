using System;
using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    public abstract class StaticManager<T> : MonoBehaviour where T : MonoBehaviour
    {
        private static T actualInstance;

        public static T Instance
        {
            get
            {
                if (actualInstance != null)
                    return actualInstance;
                actualInstance = FindObjectOfType<T>();

                actualInstance = CreateManager();
                return actualInstance;
            }
        }

        private static T CreateManager()
        {
            GameObject managerParent = new GameObject($"{typeof(T).Name}");
            T instance = managerParent.AddComponent<T>();
            DontDestroyOnLoad(managerParent);
            return instance;
        }
    }
}

