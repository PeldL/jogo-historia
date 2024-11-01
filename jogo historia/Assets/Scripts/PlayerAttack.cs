using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private float meleeSpeed;
    [SerializeField] private float damage;
    public Slider barraDeVidaDoJogador;

    public float life;
    float timeUntilMelee;

     void Start()
    {
        
        barraDeVidaDoJogador.value = life;
    }



    private void Update()
    {
        if (timeUntilMelee <= 0) 
        {
            if(Input.GetMouseButtonDown(0)) 
            {
                anim.SetTrigger("Attack");
           
            }
        }

        if (life <= 0)
        {
            Destroy(gameObject);

            SceneManager.LoadSceneAsync(3);

        }
        else 
        {
            timeUntilMelee -= Time.deltaTime;


        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            barraDeVidaDoJogador.value = life;

            other.GetComponent<Enemy>().TakeDamage(damage);
            Debug.Log("Enemy hit");

        }
    }
    public void Death()
    {

        if (life <= 0)
        {
            Destroy(gameObject);
        }
    }

}
