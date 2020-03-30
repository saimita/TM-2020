using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private Vector2 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        launch();
    }

    private void launch()
    {
        float x = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
        float y = UnityEngine.Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;//reset velocity
        transform.position = startPosition;//reset position
        launch();
    }
    public void increaseSpeed()
    {
        float velx=rb.velocity[0] +(rb.velocity[0]>0 ? 1 : -1);//keep direction but increase speed
        float vely=rb.velocity[1] +(rb.velocity[1]>0 ? 1 : -1);//keep direction but increase speed
        rb.velocity = new Vector2(velx, vely);//update speed based in initial speed
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
