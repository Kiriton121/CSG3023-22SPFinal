/**** 
 * Created by: Bob Baloney
 * Date Created: April 20, 2022
 * 
 * Last Edited by: Zhiyong Lu
 * Last Edited:
 * 
 * Description: Paddle controler on Horizontal Axis
****/

/*** Using Namespaces ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10; //speed of paddle


    // Update is called once per frame
    void Update()
    {

            speed = Input.GetAxis("Horizontal"); // horizontal movement
            if (speed != 0)
            {
                Vector3 pos = transform.position;
                pos.x += speed * Time.deltaTime * speed;
                transform.position = pos;

            }


        }//end Update()
}
