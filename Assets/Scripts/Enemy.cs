using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    public float EnemyHealth = 50;

    public Transform vfxDeath;
    public void TakeDamage(int damage)
    {
        EnemyHealth -= damage;

        if (EnemyHealth <= 0)
        {

            Invoke(nameof(DestroyEnemy), 1f);
            Instantiate(vfxDeath, transform.position, Quaternion.identity);
        }
    }
    private void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}
