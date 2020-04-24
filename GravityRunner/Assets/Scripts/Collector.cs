using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    private float width = 0.0f;
    void Awake()
    {
        width = GameObject.Find("BG").GetComponent<BoxCollider2D>().size.x;
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "BG" || target.tag == "Ground")
        {
            Vector3 position = target.transform.position;
            position.x += width * 2.90f;
            target.transform.position = position;
        }

        if (target.tag == "Coin" || target.tag == "Rocket") {
            target.gameObject.SetActive(false);
        }
    }

  
    
}
