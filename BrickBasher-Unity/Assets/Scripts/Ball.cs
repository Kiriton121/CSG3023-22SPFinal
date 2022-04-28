/**** 
 * Created by: Bob Baloney
 * Date Created: April 20, 2022
 * 
 * Last Edited by: Zhiyong Lu
 * Last Edited:
 * 
 * Description: Controls the ball and sets up the intial game behaviors. 
****/

/*** Using Namespaces ***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour
{
    [Header("General Settings")]

    public bool isInPlay;
    public GameObject paddle;
    private Rigidbody rb;

    [Header("Ball Settings")]

    public int numberOfBalls;
    public float speed;


    //Awake is called when the game loads (before Start).  Awake only once during the lifetime of the script instance.
    void Awake()
    {
        
    }//end Awake()


        // Start is called before the first frame update
        void Start()
    {
        SetStartingPos(); //set the starting position
        rb = GetComponent<Rigidbody>();

    }//end Start()


    // Update is called once per frame
    void Update()
    {
        if (isInPlay = true)
        {
            return
        }

        if (isInPlay = false)
        {
            Vector3 pos = transform.position;
            pos.x = paddle.position.x;
            pos.y = 0;
            transform.position = pos;
        } // if the game hasn't started, the ball should follow the paddle

        if (Input.GetKey(KeyCode.Space) && (isInPlay = Ture))
        {
            Vector3 NormalizedSpeed = new Vector3(1f, 1f, 0).normalized;
            rb.velocity = NormalizedSpeed * speed;
            isInPlay = true;
            Vector3 pos = paddle.postion;
            pos.x = transfrom.position.x;
            paddle.position = pos;
            Move();

        }
    
    }//end Update()


    private void LateUpdate()
    {
        if (isInPlay = ture)
        {
            velocity = speed * velocity.normalized;

        }

    }//end LateUpdate()


    void SetStartingPos()
    {
        isInPlay = false;//ball is not in play
        rb.velocity = Vector3.zero;//set velocity to keep ball stationary

        Vector3 pos = new Vector3();
        pos.x = paddle.transform.position.x; //x position of paddel
        pos.y = paddle.transform.position.y + paddle.transform.localScale.y; //Y position of paddle plus it's height
        transform.position = pos;//set starting position of the ball 
    }//end SetStartingPos()


    void Move()
    {
        
    }

    void OnCollisionEnter()
    {

    }

    void OnTriggerEnter()
    {

    }


   
 
}
