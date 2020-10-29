using System.Collections;
using UnityEngine;

namespace FutureGames.JRPG_Rocket
{
    public class HeroManager : StaticManager<HeroManager>
    {
        [SerializeField] private float SelectorBobDistance = 0.5f;
        [SerializeField] private float SelectorBobSpeed    = 2.0f;

        private Hero[]    Heroes;
        private Hero      CurrentlySelectedHero = null;
        private int       CurrentHeroIndex      = 0;
        private Transform SelectorObject        = null;


        private void Awake()
        {
            Heroes                = FindObjectsOfType<Hero>();
            SelectorObject        = transform.GetChild(0);
            CurrentlySelectedHero = Heroes[CurrentHeroIndex];
            MoveSelector(CurrentlySelectedHero.transform);
            StartCoroutine(SelectorBob());
        }

        public void SelectNextHero()
        {
            if (CurrentHeroIndex >= Heroes.Length - 1)
                return;
            CurrentHeroIndex      += 1;
            CurrentlySelectedHero =  Heroes[CurrentHeroIndex];
            MoveSelector(CurrentlySelectedHero.transform);
        }

        public void SelectPreviousHero()
        {
            if (CurrentHeroIndex == 0)
                return;
            CurrentHeroIndex      -= 1;
            CurrentlySelectedHero =  Heroes[CurrentHeroIndex];
            MoveSelector(CurrentlySelectedHero.transform);
        }

        private void MoveSelector(Transform pHeroParent)
        {
            SelectorObject.transform.position = new Vector3(pHeroParent.position.x, SelectorObject.position.y,
                pHeroParent.position.z);
            SelectorObject.SetParent(pHeroParent);
        }

        private IEnumerator SelectorBob()
        {
            while (true)
            {
                Vector3 cosTranslation =
                    new Vector3(0, SelectorBobDistance * Mathf.Cos(Time.time * SelectorBobSpeed), 0);
                SelectorObject.Translate(cosTranslation * Time.deltaTime);
                yield return null;
            }
        }

        public void QueueMovementForSelectedHero(Vector3 pMovement)
        {
            CurrentlySelectedHero.QueueMovement(pMovement);
        }

        public void RemoveCommandForSelectedHero()
        {
            CurrentlySelectedHero.RemoveLastCommand();
        }

        public void ExecuteAllHeroCommands()
        {
            foreach (Hero h in Heroes)
            {
                h.ExecuteCommands();
            }
        }

        public void QueueAttackForSelectedHero()
        {
            CurrentlySelectedHero.QueueAttack();
        }

        public void RotateHeroLeft()
        {
            CurrentlySelectedHero.RotateLeft();
        }  
        public void RotateHeroRight()
        {
            CurrentlySelectedHero.RotateRight();
        }
        
    }
}