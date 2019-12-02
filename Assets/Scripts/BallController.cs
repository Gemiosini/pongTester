using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BallController : MonoBehaviour
{
    public int leftOrRight, upOrDown;
    public float xvect, yvect;
    public float initSpeed ; 
    public Rigidbody2D rb;
    private Transform ballInitPos;
    // Start is called before the first frame update
    void Start()
    {
        ballInitPos = rb.transform;
        leftOrRight = Random.Range(0 , 2);
        ballRandomizer();
        ballDirection();

    }
    void ballRandomizer()
    {

        upOrDown = Random.Range(0 , 2);
        xvect = Random.Range(0.75f, 1.0f);
        yvect = Mathf.Sqrt(1 / (xvect * xvect));
        if (leftOrRight == 0)
        {
            xvect = -xvect;

        }
        if (upOrDown == 0)
        {
            yvect = -yvect;

        }
    }  
    void ballDirection()
    {

         rb.velocity = new Vector2(xvect * initSpeed, yvect * initSpeed);
    
    }
    /*
    void Update()
    {
        if ball hits left border, point goes to right player
            left player gets to start, so leftOrRight = 1
            rightPoint++
        if ball hits right border, point goes to left player
            so leftOrRight = 0
            leftpoint++



        for ball to increase in speed and change direction when hitting a paddle

        on trigger
        rb.velocity = new Vector (0,0)
        get paddle position
        get current ball position
        ydelta = ballYPos - Paddle YPos
        speed = absolute(ydelta) + initSpeed
        yvect = ydelta/20
        xvect = Mathf.Sqrt(1 / (yvect * yvect));
    }

    */
       
}

