using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed;
    public float start;
    public float end;
    public float max;
    public float min;
    private int _score;
    public GameObject bird;
    public GameObject gradle;
    void Start()
    {
        _score = 0;
    }

    public void GameOver()
    {
        Debug.Log("Score: "  + _score + "\nTime: " + Mathf.RoundToInt(Time.time) + "s");
        Time.timeScale = 0;
        Destroy(bird);
        Destroy(this);
    }
    void Update()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
        if (transform.position.x < end)
        {
            transform.Translate(start + 3.34f, 0, 0);
            _score += 5;
            speed += 0.5f;
        }
        if ((transform.position.x - bird.transform.position.x > -0.8f) &&
            (transform.position.x - bird.transform.position.x < 0.8f))
        {
            if ((bird.transform.position.y > max) || (bird.transform.position.y < min))
                GameOver();
        }
        if (gradle.transform.position.y - bird.transform.position.y > -1.5)
            GameOver();
    }
}
