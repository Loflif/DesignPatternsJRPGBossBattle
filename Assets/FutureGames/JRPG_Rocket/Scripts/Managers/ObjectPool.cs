using System.Collections.Generic;
using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    public class ObjectPool
    {
        private GameObject       SourceObject = null;
        private List<GameObject> Pool = new List<GameObject>();
        
        public ObjectPool(GameObject pMasterObject)
        {
            SourceObject = pMasterObject;
        }
        
        public GameObject GetPooledObject(Vector3 pPosition, Quaternion pRotation)
        {
            GameObject objectToReturn     = null;
            bool       unusedObjectExists = false;
            foreach (GameObject g in Pool)
            {
                if (!g.activeInHierarchy)
                {
                    objectToReturn     = g;
                    unusedObjectExists = true;
                    break;
                }
            }

            if (unusedObjectExists)
            {
                objectToReturn.transform.SetPositionAndRotation(pPosition, pRotation);
                return objectToReturn;
            }
            objectToReturn = GameObject.Instantiate(SourceObject, pPosition, pRotation);
            Pool.Add(objectToReturn);
            return objectToReturn;
        }
    }
}