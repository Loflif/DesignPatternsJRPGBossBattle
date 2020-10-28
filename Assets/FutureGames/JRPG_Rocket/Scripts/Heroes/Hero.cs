using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

namespace FutureGames.JRPG_Rocket
{
    public struct Command
    {
        public Command(Action pAction, GameObject pActionVisualizer)
        {
            Action           = pAction;
            ActionVisualizer = pActionVisualizer;
        }
        public Action     Action;
        public GameObject ActionVisualizer;
    }
    
    public abstract class Hero : MonoBehaviour
    {
        [SerializeField] protected float      MoveDistance   = 1f;
        [SerializeField] protected int        CommandMax     = 4;
        [SerializeField] protected GameObject MoveVisualizer = null;
        [SerializeField] protected GameObject AttackVisualizer = null;

        private Queue<Command> Commands = new Queue<Command>();

        private void AddCommand(Command pCommand)
        {
            //TODO: GetPooled visualiser and position it at where the action will take place, probably should save position if all commands go off
            if (Commands.Count < CommandMax)
                Commands.Enqueue(pCommand);
        }

        public void RemoveLastCommand()
        {
            if (Commands.Count == 0)
                return;
            Commands.Reverse(); //TODO: FIX!!
            Commands.Dequeue();
            Commands.Reverse();
        }

        public void ExecuteCommands()
        {
            foreach (Command c in Commands)
            {
                c.Action();
                //TODO: do something with the visualiser
            }

            Commands.Clear();
        }

        public virtual void QueueMoveForward()
        {
            //TODO: Make sure you can't queue commands that put you outside the grid
            void NewAction() => Move(Vector3.forward * MoveDistance);
            Command newCommand = new Command(NewAction, MoveVisualizer);
            AddCommand(newCommand);
        }

        public virtual void QueueMoveBackward()
        {
            void NewAction() => Move(Vector3.back * MoveDistance);
            Command newCommand = new Command(NewAction, MoveVisualizer);
            AddCommand(newCommand);
        }

        public virtual void QueueMoveRight()
        {
            void NewAction() => Move(Vector3.right * MoveDistance);
            Command newCommand = new Command(NewAction, MoveVisualizer);
            AddCommand(newCommand);
        }

        public virtual void QueueMoveLeft()
        {
            void NewAction() => Move(Vector3.left * MoveDistance);
            Command newCommand = new Command(NewAction, MoveVisualizer);
            AddCommand(newCommand);
        }

        private void Move(Vector3 amount)
        {
            gameObject.transform.Translate(amount);
        }
    }
}