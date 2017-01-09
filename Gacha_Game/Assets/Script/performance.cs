using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class performance : MonoBehaviour
{
    public float destroyTime = 1.0f;

    float timer = 0;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;

        if(timer >= destroyTime)
        {
            Destroy(this.gameObject);
        }
	}
}
