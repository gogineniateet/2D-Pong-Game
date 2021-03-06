using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float playerSpeed;
    Rigidbody2D rb;
    private float movement;
    public bool isPlayer1;
    public Vector3 startPosition;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        startPosition = transform.position;
    }

    // left and right player movement
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxis("Vertical1");
        }
        else
        {
            movement = Input.GetAxis("Vertical");
        }
        rb.velocity = new Vector2(rb.velocity.x, movement * playerSpeed);
    }

    public void RestartGame()
    {
        rb.velocity = Vector3.zero;
        transform.position = startPosition;
    }
}
