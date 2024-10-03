using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public Transform foot;
    bool groundCheck;
    public float speed = 5, jumpStrength = 5;
    float horizontal;
    public Rigidbody2D body;

    Collider2D footCollision;
    int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        body.velocity = new Vector2(horizontal * speed, body.velocity.y);

        //groundCheck = Physics2D.OverlapCircle(foot.position, 0.05f);
        footCollision = Physics2D.OverlapCircle(foot.position, 0.05f);
        groundCheck = footCollision;
        


        if (Input.GetButtonDown("Jump") && groundCheck)
        {
            body.AddForce(new Vector2(0, jumpStrength * 100));
        }
        if(horizontal != 0)//Para GetAxisRaw
        {
            direction = (int)horizontal;
        }
        /*Para quem está usando GetAxis
        if(horizontal < 0)
        {
            direction = -1;
        } else if(horizontal > 0)
        {
            direction = 1;
        }
        */
       


        }
    }
   