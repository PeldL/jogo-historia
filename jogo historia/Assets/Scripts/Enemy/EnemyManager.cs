using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    public int enemyKilled;
    public void EnemyKilled()
    {
        enemyKilled++;

        if (enemyKilled >= 20)
        {
            SceneManager.LoadSceneAsync(1);
            Debug.Log(enemyKilled);
        }
    }
}
