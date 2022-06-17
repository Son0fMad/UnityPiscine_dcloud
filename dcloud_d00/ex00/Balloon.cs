using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    private int breath;
    void Start()
    {
        transform.localScale += new Vector3(1, 1, 0);
        breath = 40;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && breath > 0)
        {
            breath -= 1;
            transform.localScale += new Vector3(1f, 1f, 0);
        }
        else
        {
            transform.localScale += new Vector3(-.01f, -.01f, 0);
        }
        
        if (transform.localScale.x <= 0.2 || transform.localScale.x >= 8)
        {
            GameObject.Destroy(this.gameObject);
            Debug.Log("Balloon life time: " + Mathf.RoundToInt(Time.time) + "s");
        }
    }
}
