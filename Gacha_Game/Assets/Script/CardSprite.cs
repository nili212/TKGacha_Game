using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSprite : MonoBehaviour
{
    public float initrotation = 30;
    public float deceleration = 1;
    public float minrotation = 1;

    public int spriteID = 0;

    public Sprite[] spriteData;

    private float rotationSpeed;

    // Use this for initialization
    void Start ()
    {
        rotationSpeed = initrotation;

        GetComponent<SpriteRenderer>().sprite = spriteData[spriteID - 1];
	}
	
	// Update is called once per frame
	void Update ()
    {


        if (rotationSpeed - deceleration > minrotation)
        {
            rotationSpeed -= deceleration;
            transform.eulerAngles += new Vector3(0.0f, rotationSpeed, 0.0f);
        }
        else
        {
            transform.eulerAngles += new Vector3(0.0f, minrotation, 0.0f);
        }
	}
}
