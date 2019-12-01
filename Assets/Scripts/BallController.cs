using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
         rb.velocity = new Vector2(speed , speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
