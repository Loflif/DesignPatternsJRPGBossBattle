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
        [SerializeField] protected float      MoveDistance            = 1f;
        [SerializeField] protected int        CommandMax              = 4;
        [SerializeField] protected GameObject MoveVisualizer          = null;
        [SerializeField] protected GameObject AttackVisualizer        = null;
        [SerializeField] protected Attack     CurrentlySelectedAttack = null;

        private          Vector3          SimulatedPosition = Vector3.zero;
        private          Quaternion       SimulatedRotation = Quaternion.identity;
        private readonly List<Command>    Commands          = new List<Command>();
        private readonly List<GameObject> AttackVisualizers = new List<GameObject>();

        private void Start()
        {
            SimulatedPosition                        = transform.position;
            GameObject startAttackVisualiser = PlaceAttackVisualiser(CurrentlySelectedAttack.AttackVisualiser,
                CurrentlySelectedAttack.AttackOffset, SimulatedRotation);
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

        private GameObject PlaceAttackVisualiser(GameObject pAttackVisualiser, Vector3 pPosition, Quaternion pRotation)
        {
            return ObjectPoolManager.GetPooledObject(pAttackVisualiser, pPosition, pRotation);
        }

        private void SimulateMovement(Command pCommand)
        {
            SimulatedPosition += pCommand.Movement;
        }

        private GameObject GetCommandVisualiser(GameObject pVisualiser, Vector3 pCommandMovement = default)
        {
            return ObjectPoolManager.GetPooledObject(pVisualiser, SimulatedPosition + pCommandMovement,
                SimulatedRotation);
        }

        private void ApplySimulatedRotation()
        {
            if (Commands.Count > 0)
                Commands[Commands.Count - 1].ActionVisualizer.transform.rotation = SimulatedRotation;
            else
                transform.rotation = SimulatedRotation;
        }

        //Check whether the hero has any actions left this round, otherwise don't do anything
        //Calculates the movement based on the current simulated rotation from all previous actions queued & the requested movement direction
        //Check whether the target is on the grid, otherwise don't do anything
        //Create a new command and initialize it with values of the action, visualiser and movement of the command
        //Calculate the new simulatedPosition of the round
        //Add command to the list
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

        //Add -90 degrees to the simulated rotation and apply that rotation to either the hero or the last visualiser
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
            gameObject.transform.position += pAmount;
        }

        private void Attack(Attack pAttack)
        {
            //TODO: make attack scriptableObjects that specify size and damage and somehow damage things in that area (BoxCast?)
        }
    }
}