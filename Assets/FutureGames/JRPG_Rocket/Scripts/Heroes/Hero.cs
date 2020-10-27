using System;
using System.Collections.Generic;
using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    // public enum HeroState
    // {
    //     Sleeping,
    //     Selected,
    //     Active,
    // }

    public abstract class Hero : MonoBehaviour
    {
        [SerializeField] protected float MoveDistance = 1f;
        [SerializeField] protected int   CommandCount = 4;
        
        // protected HeroState heroState = HeroState.Sleeping;

        private Queue<Action> commands = new Queue<Action>();

        private void AddCommand(Action pAction)
        {
            commands.Enqueue(pAction);
        }

        public void ExecuteCommands()
        {
            foreach (Action a in commands)
            {
                a();
            }

            commands.Clear();
        }

        public virtual void QueueMoveForward()
        {
            AddCommand(() => Move(Vector3.forward * MoveDistance));
        }
        public virtual void QueueMoveBackward()
        {
            AddCommand(() => Move(Vector3.back * MoveDistance));
        }

        public virtual void QueueMoveRight()
        {
            AddCommand(() => Move(Vector3.right * MoveDistance));
        }

        public virtual void QueueMoveLeft()
        {
            AddCommand(() => Move(Vector3.left * MoveDistance));
        }

        // public abstract void ChangeState(HeroState newState);

        private void Move(Vector3 amount)
        {
            gameObject.transform.Translate(amount);
        }
    }
}