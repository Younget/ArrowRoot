using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
    public float minDelay = 1;
    public float maxDelay = 30;
    public GameObject[] enemyThing;
    // Use this for initialization
    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));
            GameObject eClone = Instantiate(enemyThing[Random.Range(0, enemyThing.Length)], transform.position, transform.rotation);
        }
    }

        // Update is called once per frame
        void Update () {
		
	}
}
