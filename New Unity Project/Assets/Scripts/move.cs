using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{


    // Start is called before the first frame update
    private void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(-200f, 0f));
    }
}