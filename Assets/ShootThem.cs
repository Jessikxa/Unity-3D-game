using JetBrains.Annotations;
using UnityEngine;

public class ShootThem : MonoBehaviour
{
    public int hp = 30;

    public void TakeDamage(int damage)
    {
        hp -= damage;

        if (hp < 0)
        {
            Die();
        }
    }

        public void Die()
        {
            Destroy(gameObject);
        }
    }
