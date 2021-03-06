﻿using System.Collections.Generic;
using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    public class ObjectPoolManager : StaticManager<ObjectPoolManager>
    {
        private Dictionary<GameObject, ObjectPool> Pools;

        private void Awake()
        {
            Pools = new Dictionary<GameObject, ObjectPool>();
        }
        //Check if objectPool for requested already exists, otherwise create one
        //Get object from objectPool
        public static GameObject GetPooledObject(GameObject pPrefab, Vector3 pPosition, Quaternion pRotation)
        {
            if (!Instance.Pools.ContainsKey(pPrefab))
            {
                Instance.Pools[pPrefab] = new ObjectPool(pPrefab);
            }

            return Instance.Pools[pPrefab].GetPooledObject(pPosition, pRotation);
        }
    }
}