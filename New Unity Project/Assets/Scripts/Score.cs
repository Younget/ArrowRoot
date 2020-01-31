using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    float playerScore;
    float increaseAmount;

    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0f;
        increaseAmount = 500f;
    }
    




    // Update is called once per frame
    void FixedUpdate()
    {
        playerScore += increaseAmount * Time.deltaTime;
    }
}
