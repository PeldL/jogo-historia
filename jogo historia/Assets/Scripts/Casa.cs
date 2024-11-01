using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Casa : MonoBehaviour
{
    public float life = 100;
    public Slider vuoida;

    // Start is called before the first frame update
    void Start()
    {
         vuoida.value = 100;
    }
    // Update is called once per frame



    void Update()
    {
        vuoida.value = life;    
        if(life <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadSceneAsync(3);
        }
    }
    
}
