using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour
{
    public GameObject leftPlatform;
    public GameObject rightPlatform;
    public float speed;

    private float _hSpeed;
    private float _vSpeed;
    private bool _reset;
    private int _scoreLeft;
    private int _scoreRight;

    void Start()
    {
        int choice = Random.Range(0, 2);
        _vSpeed = choice == 0 ? -speed / 10 : speed / 10;
        choice = Random.Range(0, 2);
        _hSpeed = choice == 0 ? -speed / 10 : speed / 10;
        _reset = false;
        _scoreLeft = 0;
        _scoreRight = 0;
    }

    void Update()
    {
        if (transform.position.x < -9)
        {
            _scoreRight++;
            _reset = true;
        }       
        if (transform.position.x > 9)
        {
            _scoreLeft++;
            _reset = true;
        }

        if (_reset)
        {
            _reset = false;
            Debug.Log("Player 1: " + _scoreLeft + " | Player 2: " + _scoreRight);
            transform.position = new Vector3(0, 0, 0);
            int choice = Random.Range(0, 2);
            _vSpeed = choice == 0 ? -speed / 10 : speed / 10;
            choice = Random.Range(0, 2);
            _hSpeed = choice == 0 ? -speed / 10 : speed / 10;
        }

        if (transform.position.y + _vSpeed > 4.7 || transform.position.y + _vSpeed < -4.7)
            _vSpeed = -_vSpeed;
        if (transform.position.x + _hSpeed < -7.5 && transform.position.x + _hSpeed > -7.7)
        {
            if (Mathf.Abs(leftPlatform.transform.position.y - transform.position.y) < 2)
                _hSpeed = -_hSpeed;
            _hSpeed *= 1.1f;
        }
        else if (transform.position.x + _hSpeed > 7.5 && transform.position.x + _hSpeed < 7.7)
        {
            if (Mathf.Abs(rightPlatform.transform.position.y - transform.position.y) < 2)
                _hSpeed = -_hSpeed;
            _hSpeed *= 1.1f;
        }
        transform.Translate(_hSpeed, _vSpeed, 0f);
    }
}
