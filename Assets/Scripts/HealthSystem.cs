using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class HealthSystem : MonoBehaviour
{

    [System.Serializable]
    public class OnDamagedEvent : UnityEvent<int> { }

        public int health = 10;
        public UnityEvent onDie;
        public OnDamagedEvent onDamaged;
        public void TakeDamage(int damage)
        {
            health -= damage;
            onDamaged.Invoke(health);
        if (health < 1)
            {
                onDie.Invoke();
            }
        }
    }

