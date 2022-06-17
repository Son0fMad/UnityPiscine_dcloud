using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject leftPlatform;
    public GameObject rightPlatform;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) && leftPlatform.transform.position.y < 3f)
            leftPlatform.transform.Translate(0, 0.1f, 0);
        else if (Input.GetKey(KeyCode.S) && leftPlatform.transform.position.y > -3f)
            leftPlatform.transform.Translate(0, -0.1f, 0);
        if (Input.GetKey(KeyCode.UpArrow) && rightPlatform.transform.position.y < 3f)
            rightPlatform.transform.Translate(0, 0.1f, 0);
        else if (Input.GetKey(KeyCode.DownArrow) && rightPlatform.transform.position.y > -3f)
            rightPlatform.transform.Translate(0, -0.1f, 0);
    }
}
