using UnityEngine;
using UnityEngine.UI;

namespace FutureGames.JRPG_Rocket
{
    public abstract class Enemy : MonoBehaviour
    {
        [SerializeField] float MaxHealth = 100.0f;

        private float  CurrentHealth = 0.0f;
        private Slider HealthSlider  = null;

        private void Awake()
        {
            HealthSlider = GetComponentInChildren<Slider>();
        }

        private void Start()
        {
            CurrentHealth = MaxHealth;
        }

        public void TakeDamage(float pDamage)
        {
            CurrentHealth -= pDamage;
            if (CurrentHealth <= 0.0f)
            {
                HealthSlider.value = 0.0f;
                Die();
                return;
            }

            HealthSlider.value = CurrentHealth / MaxHealth;
        }

        private void Die()
        {
            gameObject.SetActive(false);
        }
    }
}