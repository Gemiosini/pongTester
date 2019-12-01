using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiController : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Rigidbody2D ballrb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.position.y < ballrb.position.y)
        {
            rb.velocity = new Vector2(rb.velocity.x , speed); 
        }
       else if(rb.position.y > ballrb.position.y)
       {

           rb.velocity = new Vector2(rb.velocity.x , -1*speed);
       }
       else
       {
           rb.velocity = new Vector2(rb.velocity.x , 0);
       }
    }
}
