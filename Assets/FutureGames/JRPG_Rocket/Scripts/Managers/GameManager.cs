using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    public class GameManager : StaticManager<GameManager>
    {
        public static Bounds GridBounds;
        public static float  GridSize = 1.0f;

        private void Awake()
        {
            GridBounds = GameObject.Find("Ground").GetComponent<Collider>().bounds;
        }
    }
}