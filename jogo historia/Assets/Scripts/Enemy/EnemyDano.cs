using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDano : MonoBehaviour
{
    [SerializeField] public float cooldown = 3;
    bool isTouching;
    bool isTouchingPlayer;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Casa"))
        {
            isTouching = true;
            StartCoroutine(AtaqueInimigo());
        }
        if (collision.CompareTag("Player"))
        {
            isTouchingPlayer = true;
            StartCoroutine(AtaqueInimigoP());
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Casa"))
        {
            isTouching = false;
        }
        if (collision.CompareTag("Player"))
        {
            isTouchingPlayer = false;
            
        }

    }
    public void Ataque()
    {
        Casa casa = FindObjectOfType<Casa>();
        casa.life -= 10;
    }
    public void AtaquePlayer()
    {
        PlayerAttack player = FindObjectOfType<PlayerAttack>();
        player.life -= 10;
    }
    public IEnumerator AtaqueInimigo()
    {
        Ataque();
        yield return new WaitForSeconds(cooldown);
        if (isTouching)
        {
            StartCoroutine(AtaqueInimigo());
        }

    }
    public IEnumerator AtaqueInimigoP()
    {
        AtaquePlayer();
        yield return new WaitForSeconds(cooldown);
        if (isTouchingPlayer)
        {
            StartCoroutine(AtaqueInimigoP());
        }

    }
}
