using System;
using System.Collections.Generic;
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
        [SerializeField] protected Attack     HeroAttack     = null;

        private List<Command> Commands                    = new List<Command>();
        private GameObject    CurrentAttackVisualiser     = null;
        private Transform     CurrentlySimulatedTransform = null;
        private Transform     OwnTransform;


        private void Awake()
        {
            OwnTransform                = transform;
            CurrentlySimulatedTransform = OwnTransform;
        }

        private void Start()
        {
            CurrentAttackVisualiser = GetActionVisualiser(HeroAttack.AttackVisualiser,
                CurrentlySimulatedTransform.position + HeroAttack.AttackOffset,
                CurrentlySimulatedTransform.rotation);
            CurrentAttackVisualiser.transform.SetParent(CurrentlySimulatedTransform, true);
            CurrentAttackVisualiser.SetActive(false);
        }

        public void RemoveLastCommand()
        {
            if (Commands.Count == 0)
                return;
            int     lastIndex       = Commands.Count - 1;
            Command unWantedCommand = Commands[lastIndex];
            Commands.RemoveAt(lastIndex);
            unWantedCommand.ActionVisualizer.SetActive(false);
            SetSimulatedTransform(Commands.Count > 0
                ? Commands[Commands.Count - 1].ActionVisualizer.transform
                : OwnTransform);
        }

        public void ExecuteCommands()
        {
            foreach (Command c in Commands)
            {
                c.Action();
                c.ActionVisualizer.SetActive(false);
            }

            Commands.Clear();
            OwnTransform.rotation = CurrentlySimulatedTransform.rotation;
            OwnTransform.position = CurrentlySimulatedTransform.position;
            SetSimulatedTransform(OwnTransform);
        }

        private void SetSimulatedTransform(Transform pToSimulate)
        {
            CurrentlySimulatedTransform = pToSimulate;
            CurrentAttackVisualiser.transform.SetParent(CurrentlySimulatedTransform, false);
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

        private GameObject GetActionVisualiser(GameObject pVisualiser, Vector3 pPosition, Quaternion pRotation)
        {
            return ObjectPoolManager.GetPooledObject(pVisualiser, pPosition, pRotation);
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
            Vector3 moveVector = CurrentlySimulatedTransform.rotation *
                                 (pDirection * MoveDistance * GameManager.GridSize);

            if (!PointIsOnGrid(CurrentlySimulatedTransform.position + moveVector))
                return;

            void MoveAction() => Move(moveVector);
            GameObject moveVisualiser =
                GetActionVisualiser(MoveVisualizer, CurrentlySimulatedTransform.position + moveVector,
                    CurrentlySimulatedTransform.rotation);
            Command move = new Command(MoveAction, moveVisualiser);
            SetSimulatedTransform(moveVisualiser.transform);
            Commands.Add(move);
        }

        public virtual void QueueAttack()
        {
            if (!HasActionsLeft())
                return;

            Vector3   pos       = CurrentlySimulatedTransform.position;
            Vector3   hitBox    = HeroAttack.AttackHitBox;
            Vector3   offset    = CurrentlySimulatedTransform.rotation * HeroAttack.AttackOffset;
            float     damage    = HeroAttack.Damage;
            LayerMask hitLayers = HeroAttack.HitLayers;
            void AttackAction() => Attack(pos, offset, hitBox, damage, CurrentlySimulatedTransform.rotation, hitLayers);
            GameObject attackVisualiser = GetActionVisualiser(HeroAttack.AttackVisualiser,
                pos + offset,
                CurrentlySimulatedTransform.rotation);
            Command attack = new Command(AttackAction, attackVisualiser);
            Commands.Add(attack);
        }

        public void ToggleAttackVisualiser(bool pEnable)
        {
            CurrentAttackVisualiser.SetActive(pEnable);
        }

        public void Rotate(Vector3 pAxis, float pDegrees)
        {
            CurrentlySimulatedTransform.Rotate(pAxis, pDegrees);
            HeroAttack.AttackVisualiser.transform.RotateAround(CurrentlySimulatedTransform.position, pAxis,
                pDegrees);
        }

        private void Move(Vector3 pAmount)
        {
            gameObject.transform.position += pAmount;
        }

        private void Attack(Vector3 pPosition, Vector3 pOffset, Vector3 pHitBox, float pDamage, Quaternion pOrientation,
            LayerMask               pHitLayers)
        {
            Vector3 halfExtents = pHitBox * 0.5f;
            Vector3 direction   = (pOffset).normalized;
            if (Physics.BoxCast(pPosition, halfExtents, direction, out RaycastHit hit, Quaternion.identity, pOffset.magnitude,
                pHitLayers))
            {
                hit.transform.GetComponent<Enemy>().TakeDamage(pDamage);
            }
        }
    }
}