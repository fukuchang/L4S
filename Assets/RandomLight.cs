using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLight : MonoBehaviour {

    int m_rnd;

    Light m_light;
    
	// Use this for initialization
	void Start () {
        m_light = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        m_rnd = Random.Range(0, 10);
        Debug.Log(m_rnd);
        if (m_rnd > 8)
        {
            m_light.intensity = 2.5f;
        }
        else
        {
            m_light.intensity = 0f;
        }
	}
}
