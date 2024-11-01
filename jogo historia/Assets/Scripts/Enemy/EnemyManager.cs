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

        if (enemyKilled >= 30)
        {
            SceneManager.LoadSceneAsync(4);
            Debug.Log(enemyKilled);
        }
    }
}
