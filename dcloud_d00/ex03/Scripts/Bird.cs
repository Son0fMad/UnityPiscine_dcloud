using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float velocity = 0.5f;
    void Start()
    {
		Time.timeScale = 1;
    }


    void Update()
    {
	    if (Input.GetKeyDown(KeyCode.Space))
        {
	        transform.Translate(0, velocity, 0);
        }
        else
        {
	        transform.Translate(0, -velocity * Time.deltaTime * 2f, 0);
        }
	}
}
