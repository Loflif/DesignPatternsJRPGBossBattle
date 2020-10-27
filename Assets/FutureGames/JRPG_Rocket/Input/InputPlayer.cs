using UnityEngine;
using UnityEngine.InputSystem;

namespace FutureGames.JRPG_Rocket
{
    public class InputPlayer : MonoBehaviour
    {
        private CommandInput Input = null;

        private Hero SelectedHero = null;

        private void Awake()
        {
            Input        = new CommandInput();
            SelectedHero = FindObjectOfType<Hero>(); //TODO: actually change so you can select different heroes
        }

        private void OnEnable()
        {
            BindInput();
            Input.Enable();
        }

        private void OnDisable()
        {
            UnbindInput();
            Input.Disable();
        }

        private void BindInput()
        {
            Input.PlayerOne.MoveForwards.performed    += SendMoveForwardsCommand;
            Input.PlayerOne.MoveBackwards.performed   += SendMoveBackwardsCommand;
            Input.PlayerOne.MoveLeft.performed        += SendMoveLeftCommand;
            Input.PlayerOne.MoveRight.performed       += SendMoveRightCommand;
            Input.PlayerOne.ExecuteCommands.performed += ExecuteCommands;
        }

        private void UnbindInput()
        {
            Input.PlayerOne.MoveForwards.performed    -= SendMoveForwardsCommand;
            Input.PlayerOne.MoveBackwards.performed   -= SendMoveBackwardsCommand;
            Input.PlayerOne.MoveLeft.performed        -= SendMoveLeftCommand;
            Input.PlayerOne.MoveRight.performed       -= SendMoveRightCommand;
            Input.PlayerOne.ExecuteCommands.performed -= ExecuteCommands;
        }

        private void SendMoveForwardsCommand(InputAction.CallbackContext pContext)
        {
            SelectedHero.QueueMoveForward();
        }

        private void SendMoveBackwardsCommand(InputAction.CallbackContext pContext)
        {
            SelectedHero.QueueMoveBackward();
        }

        private void SendMoveLeftCommand(InputAction.CallbackContext pContext)
        {
            SelectedHero.QueueMoveLeft();
        }

        private void SendMoveRightCommand(InputAction.CallbackContext pContext)
        {
            SelectedHero.QueueMoveRight();
        }

        private void ExecuteCommands(InputAction.CallbackContext pContext)
        {
            SelectedHero.ExecuteCommands();
        }
    }
}