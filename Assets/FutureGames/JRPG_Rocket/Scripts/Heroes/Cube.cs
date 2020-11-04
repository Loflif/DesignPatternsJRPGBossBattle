using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    public class Cube : Hero
    {
        public override void QueueAttack()
        {
            base.QueueAttack();
            Rotate(Vector3.up, 180);
            base.QueueAttack();
            Rotate(Vector3.up, 180);
        }
    }
}