using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loss : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ballTag"))//When colide with the gameObject with the tag
        {
            GameObject.Find("ball").GetComponent<ball>().Reset();
            GameObject.Find("gameManagerObj").GetComponent<manager>().Reset();//Call function to reset score in manager class
            GameObject.Find("paddle").GetComponent<paddle>().Reset();
        }
    }
}
