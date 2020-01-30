using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBG : MonoBehaviour
{
    Vector3 bgPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xPos = GetComponent<Transform>().position.x;
        if (xPos <= -30.0f)
            xPos = 30.0f;
        else
            xPos -= .1f;
        bgPosition.x = xPos;
        gameObject.transform.position = bgPosition;

    }
}
