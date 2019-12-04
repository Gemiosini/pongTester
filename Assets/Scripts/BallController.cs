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
    private Vector3 ballInitPos, leftPaddleInitPos, rightPaddleInitPos, leftBoundPos, rightBoundPos;
    public Transform ballPos, leftPaddlePos, rightPaddlePos;
    // Start is called before the first frame update
    public Text leftTxt, rightTxt;

    public int leftScore, rightScore;
    void Start()
    {   
        ballInitPos = ballPos.transform.position;
        leftPaddleInitPos = leftPaddlePos.transform.position;
        rightPaddleInitPos = rightPaddlePos.transform.position;
        leftOrRight = Random.Range(0 , 2);
        ballRandomizer();
        Invoke("ballDirection", 3);
        leftScore = 0;
        rightScore = 0;
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
    
    void Update()
    {
        if(ballPos.position.x < -83.43)
        {
            resetPosition();
            rightScore++;
            rightTxt.text = "" + rightScore;
            //resetPosition();
            leftOrRight = 1;
            rb.velocity = new Vector2(0,0);
            ballRandomizer();
            Invoke("ballDirection", 3);

        }

        else if(ballPos.position.x > 63.32)
        {
            resetPosition();
            leftScore++;
            leftTxt.text =  "" + leftScore;
            //resetPosition();
            leftOrRight = 0;
            rb.velocity = new Vector2(0,0);
            ballRandomizer();
            Invoke("ballDirection", 3);
            
        }
        else
        {

        } 
        rightTxt.text = "" + rightScore;
        leftTxt.text =  "" + leftScore;
    
    
    }


   /*     for ball to increase in speed and change direction when hitting a paddle

        on trigger
        rb.velocity = new Vector (0,0)
        get paddle position
        get current ball position
        ydelta = ballYPos - Paddle YPos
        speed = absolute(ydelta) + initSpeed
        yvect = ydelta/20
        xvect = Mathf.Sqrt(1 / (yvect * yvect));
        */
    

    void resetPosition()
    {
    rightPaddlePos.transform.position = rightPaddleInitPos;
    leftPaddlePos.transform.position = leftPaddleInitPos;
    ballPos.transform.position = ballInitPos;

    }
       
}

