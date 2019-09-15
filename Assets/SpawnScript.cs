using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour {

    public float seconds = 1f;
    public GameObject enemy;

    float time = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        if(time >= seconds)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
            time = 0f;
        }
        
	}
}
