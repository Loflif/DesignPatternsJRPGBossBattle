using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    public class Sphere : Hero
    {
        public override void QueueMovement(Vector3 pDirection)
        {
            QueueAttack();
            base.QueueMovement(pDirection);
        }
    }
}