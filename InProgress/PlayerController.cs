/* Prototype Player Controller
 * By: Ethan Young
 * Description: Player should be able to jump and duck 
 * Last Updated: 1/30/19
 * */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool jumpCheck = true;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            jumpCheck = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //set rb to be Rigidbody2D
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //Player jumps when Space is pressed
        if (Input.GetKeyDown("space"))
        {
            if (jumpCheck == true)
            {
                float jump = 7f;
                rb.velocity = Vector2.up * jump;
            }
            jumpCheck = false;
        }
        //Player jumps when arrowUp is pressed
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (jumpCheck == true)
            {
                float jump = 7f;
                rb.velocity = Vector2.up * jump;
            }
            jumpCheck = false;
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.localScale = new Vector3(1, 1f, 1);
            float fall = 25f;
            rb.velocity = Vector2.down * fall;
        }
        else
        {
            gameObject.transform.localScale = new Vector3(1, 2f, 1);
            
        }
    }
}
