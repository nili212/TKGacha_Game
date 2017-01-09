using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RarityStar : MonoBehaviour
{
    public Sprite[] spriteData;

    public int rarityStarID;

	// Use this for initialization
	void Start ()
    {
        GetComponent<SpriteRenderer>().sprite = spriteData[rarityStarID];
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
