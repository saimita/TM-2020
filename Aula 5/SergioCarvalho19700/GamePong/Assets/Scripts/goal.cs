using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ballTag"))//When colide with the gameObject with the tag
        {
            GameObject.Find("gameManagerObj").GetComponent<manager>().Player1Scored();//Call function to increment score in manager class
        }
    }
}
