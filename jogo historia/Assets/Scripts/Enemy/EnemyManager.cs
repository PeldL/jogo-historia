using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class EnemyManager : MonoBehaviour
{
    public int enemyKilled;
    public Text textoEnemy;
    public void Start()
    {
        textoEnemy.text = "Derrotados: " + enemyKilled;
    }
    public void EnemyKilled()
    {
        enemyKilled++;
        textoEnemy.text = "Derrotados: " + enemyKilled;
        if (enemyKilled >= 30)
        {

            SceneManager.LoadSceneAsync(4);
            Debug.Log(enemyKilled);
        }
    }
}
