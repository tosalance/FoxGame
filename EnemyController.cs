using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed;

    public Transform leftPoint, rightPoint;

    private bool movingRight;

    private Rigidbody2D theRB;

    public SpriteRenderer theSR;

    public float moveTime, waitTime;
    private float moveCount, waitCount;



    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
        
        leftPoint.parent = null; 
        rightPoint.parent = null;
        //null is the value of a reference variable when it doesn't point to anything in memory

        movingRight = true;

        moveCount = moveTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveCount > 0)
        { 
            moveCount -= Time.deltaTime;

            if (movingRight)
            {
                theRB.velocity = new Vector2(moveSpeed, theRB.velocity.y);

                theSR.flipX = true;

                if (transform.position.x > rightPoint.position.x)
                {
                    movingRight = false;
                }
            }

            else
            {
                theRB.velocity = new Vector2(-moveSpeed, theRB.velocity.y);

                theSR.flipX = false;

                if (transform.position.x < leftPoint.position.x)
                {
                    movingRight = true;
                }

            }

            if(moveCount <= 0) 
            {
               /* waitCount = waitTime;*/
               // or randomize with below code line
                waitCount = Random.Range(waitTime * .75f, waitTime * 1.25f);
            }
        }else if(waitCount > 0)
            {
            waitCount -= Time.deltaTime;
            theRB.velocity = new Vector2(0F, theRB.velocity.y);

            if(waitCount <= 0)
            {
                /*moveCount = moveTime;*/

                moveCount = Random.Range(moveTime * .75f, waitTime * .75f);
            }

            }

       
    }
}
