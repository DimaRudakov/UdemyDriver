using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverController : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1.0f;
    [SerializeField] float moveSpeed = 20f;
    [SerializeField] float speedUp = 40f;
    [SerializeField] float slowDown = 10f;
    [SerializeField] float defaultSpeed = 20f;

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = defaultSpeed;

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Booster")
        {
            moveSpeed = speedUp;
        }

        if (other.tag == "SlowDown")
        {
            moveSpeed = slowDown;
        }
    }
}
