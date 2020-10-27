using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    public class InputPlayer : MonoBehaviour
    {
        private CommandInput CommandInput = null;

        private void Awake()
        {
            CommandInput = new CommandInput();        
        }

        private void OnEnable()
        {
            
        }

        private void OnDisable()
        {
            
        }
    }   
}
