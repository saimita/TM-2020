using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private Vector3 startPosition;
    private float movement;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Vertical");//default by unity, to use w e s for movement
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);//set velocity of paddle
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;//reset velocity
        transform.position = startPosition;//reset position
    }
}
