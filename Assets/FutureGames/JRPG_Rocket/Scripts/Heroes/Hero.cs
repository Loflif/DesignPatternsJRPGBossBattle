using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

namespace FutureGames.JRPG_Rocket
{
    public struct Command
    {
        public Command(Action pAction, GameObject pActionVisualizer, Vector3 pMovementChange = default)
        {
            Action           = pAction;
            ActionVisualizer = pActionVisualizer;
            Movement         = pMovementChange;
        }

        public Action     Action;
        public Vector3    Movement;
        public GameObject ActionVisualizer;
    }

    public abstract class Hero : MonoBehaviour
    {
        [SerializeField] protected float      MoveDistance     = 1f;
        [SerializeField] protected int        CommandMax       = 4;
        [SerializeField] protected GameObject MoveVisualizer   = null;
        [SerializeField] protected GameObject AttackVisualizer = null;

        private          Vector3       SimulatedPosition = Vector3.zero;
        private          Quaternion    SimulatedRotation = Quaternion.identity;
        private readonly List<Command> Commands          = new List<Command>();

        private void Start()
        {
            SimulatedPosition = transform.position;
        }

        private void AddCommand(Command pCommand)
        {
            Commands.Add(pCommand);
        }

        public void RemoveLastCommand()
        {
            if (Commands.Count == 0)
                return;
            int     lastIndex       = Commands.Count - 1;
            Command unWantedCommand = Commands[lastIndex];
            Commands.RemoveAt(lastIndex);
            unWantedCommand.ActionVisualizer.SetActive(false);
            SimulatedPosition -= unWantedCommand.Movement;
            if (Commands.Count == 0)
                SimulatedRotation = transform.rotation;
        }

        public void ExecuteCommands()
        {
            foreach (Command c in Commands)
            {
                c.Action();
                c.ActionVisualizer.SetActive(false);
                //TODO: execute commands slowly
            }

            Commands.Clear();
            SimulatedPosition  = transform.position;
            transform.rotation = SimulatedRotation;
        }

        private bool PointIsOnGrid(Vector3 pPoint)
        {
            var     gridBounds  = GameManager.GridBounds;
            Vector3 pointOnGrid = new Vector3(pPoint.x, gridBounds.center.y, pPoint.z);
            return gridBounds.Contains(pointOnGrid);
        }

        private bool HasActionsLeft()
        {
            return Commands.Count < CommandMax;
        }


        private void SimulateMovement(Command pCommand)
        {
            SimulatedPosition += pCommand.Movement;
        }

        private GameObject GetCommandVisualiser(GameObject pVisualiser, Vector3 pCommandMovement = default)
        {
            return ObjectPoolManager.GetPooledObject(pVisualiser, SimulatedPosition + pCommandMovement,
                SimulatedRotation); //TODO: make simulated rotation :)
        }

        private void ApplySimulatedRotation()
        {
            if (Commands.Count > 0)
                Commands[Commands.Count -1].ActionVisualizer.transform.rotation = SimulatedRotation;
            else
                transform.rotation = SimulatedRotation;
        }
        
        public virtual void QueueMovement(Vector3 pDirection)
        {
            if (!HasActionsLeft())
                return;
            Vector3 moveVector = SimulatedRotation * (pDirection * MoveDistance * GameManager.GridSize);

            if (!PointIsOnGrid(SimulatedPosition + moveVector))
                return;

            void MoveAction() => Move(moveVector);
            GameObject newVisualiser = GetCommandVisualiser(MoveVisualizer, moveVector);
            Command    newCommand    = new Command(MoveAction, newVisualiser, moveVector);
            SimulateMovement(newCommand);
            AddCommand(newCommand);
        }

        public virtual void QueueAttack()
        {
            if (!HasActionsLeft())
                return;

            // void AttackAction() => Attack();
        }
        
        //TODO: make functionality to select abilities on the heroes and always visualise the selected one in front of the selected hero (turn off when not selected)

        public void RotateLeft()
        {
            SimulatedRotation *= Quaternion.Euler(0, -90, 0);
            ApplySimulatedRotation();
        }

        public void RotateRight()
        {
            SimulatedRotation *= Quaternion.Euler(0, 90, 0);
            ApplySimulatedRotation();
        }

        private void Move(Vector3 pAmount)
        {
            gameObject.transform.Translate(pAmount);
        }

        private void Attack(Vector3 pAttackPosition)
        {
            //TODO: make attack scriptableObjects that specify size and damage and somehow damage things in that area (BoxCast?)
        }
    }
}