using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace FutureGames.JRPG_Rocket
{
    public class InputPlayer : MonoBehaviour
    {
        private CommandInput Input = null;

        private void Awake()
        {
            Input = new CommandInput();
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

        //Subscribe input functions to the events in the inputSystem
        private void BindInput()
        {
            Input.PlayerOne.MoveForwards.performed       += SendMoveForwardsCommand;
            Input.PlayerOne.MoveBackwards.performed      += SendMoveBackwardsCommand;
            Input.PlayerOne.MoveLeft.performed           += SendMoveLeftCommand;
            Input.PlayerOne.MoveRight.performed          += SendMoveRightCommand;
            Input.PlayerOne.ExecuteCommands.performed    += ExecuteCommands;
            Input.PlayerOne.ChangeSelectedHero.performed += ChangeSelectedHero;
            Input.PlayerOne.RemoveLastCommand.performed  += RemoveLastCommand;
            Input.PlayerOne.RotateLeft.performed         += RotateHeroLeft;
            Input.PlayerOne.RotateRight.performed        += RotateHeroRight;
        }

        private void UnbindInput()
        {
            Input.PlayerOne.MoveForwards.performed       -= SendMoveForwardsCommand;
            Input.PlayerOne.MoveBackwards.performed      -= SendMoveBackwardsCommand;
            Input.PlayerOne.MoveLeft.performed           -= SendMoveLeftCommand;
            Input.PlayerOne.MoveRight.performed          -= SendMoveRightCommand;
            Input.PlayerOne.ExecuteCommands.performed    -= ExecuteCommands;
            Input.PlayerOne.ChangeSelectedHero.performed -= ChangeSelectedHero;
            Input.PlayerOne.RemoveLastCommand.performed  -= RemoveLastCommand;
            Input.PlayerOne.RotateLeft.performed         -= RotateHeroLeft;
            Input.PlayerOne.RotateRight.performed        -= RotateHeroRight;
        }

        private void SendMoveForwardsCommand(InputAction.CallbackContext pContext)
        {
            HeroManager.Instance.QueueMovementForSelectedHero(Vector3.forward);
        }

        private void SendMoveBackwardsCommand(InputAction.CallbackContext pContext)
        {
            HeroManager.Instance.QueueMovementForSelectedHero(Vector3.back);
        }

        private void SendMoveLeftCommand(InputAction.CallbackContext pContext)
        {
            HeroManager.Instance.QueueMovementForSelectedHero(Vector3.left);
        }

        private void SendMoveRightCommand(InputAction.CallbackContext pContext)
        {
            HeroManager.Instance.QueueMovementForSelectedHero(Vector3.right);
        }

        private void SendAttackCommand(InputAction.CallbackContext pContext)
        {
            HeroManager.Instance.QueueAttackForSelectedHero();
        }

        private void RotateHeroLeft(InputAction.CallbackContext pContext)
        {
            HeroManager.Instance.RotateHeroLeft();
        }

        private void RotateHeroRight(InputAction.CallbackContext pContext)
        {
            HeroManager.Instance.RotateHeroRight();
        }

        private void RemoveLastCommand(InputAction.CallbackContext pContext)
        {
            HeroManager.Instance.RemoveCommandForSelectedHero();
        }

        private void ChangeSelectedHero(InputAction.CallbackContext pContext)
        {
            float scrollValue = pContext.ReadValue<float>();
            if (scrollValue > 0)
            {
                HeroManager.Instance.SelectNextHero();
            }
            else
            {
                HeroManager.Instance.SelectPreviousHero();
            }
        }

        private void ExecuteCommands(InputAction.CallbackContext pContext)
        {
            HeroManager.Instance.ExecuteAllHeroCommands();
        }
    }
}