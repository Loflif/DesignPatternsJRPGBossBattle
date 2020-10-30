using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    [CreateAssetMenu(fileName = "newAttack", menuName = "ScriptableObject/Attack", order = 0)]
    public class Attack : ScriptableObject
    {
        public Vector3    AttackOffset     = new Vector3(0, 0, 1);
        public Vector3    AttackHitBox     = new Vector3(1, 1, 1);
        public float      Damage           = 1.0f;
        public GameObject AttackVisualiser = null;
        //TODO: add ailment scriptableObjects? :)
    }   
}
