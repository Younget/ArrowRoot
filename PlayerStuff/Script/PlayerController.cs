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
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //set rb to be Rigidbody2D
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //Player jumps when Space is pressed
        if (Input.GetKeyDown("space"))
        {
            float jump = 7f;
            rb.velocity = Vector2.up * jump;

        }
        //Player jumps when arrowUp is pressed
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            float jump = 7f;
            rb.velocity = Vector2.up * jump;
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.localScale = new Vector3(1, 1f, 1);
        }
        else
        {
            gameObject.transform.localScale = new Vector3(1, 2f, 1);
        }
    }
}
