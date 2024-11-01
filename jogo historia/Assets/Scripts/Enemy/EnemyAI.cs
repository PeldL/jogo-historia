
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public GameObject target; // O GameObject que o inimigo deve seguir
    public float speed = 4f; // Velocidade do inimigo

    void Update()
    {
        if (target != null)
        {
            // Calcular a dire��o do inimigo em dire��o ao alvo
            Vector2 direction = (target.transform.position - transform.position).normalized;

            // Mover o inimigo em dire��o ao alvo
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        }
    }
}

