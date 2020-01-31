using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
