using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    [SerializeField] public float health;
    
    public void TakeDamage(float damage)
    {
        health -= damage;
        EnemyManager enemy = FindObjectOfType<EnemyManager>();

        if (health <= 0f)
        {

            Debug.Log("enemyKilled");
            enemy.EnemyKilled();
            Destroy(gameObject);
            

        }

    }
    




}
