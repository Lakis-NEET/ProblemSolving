using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDestroy : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Dot") 
        {
            ScoreControl.score += 1;
            Destroy(gameObject);
        }
    }
}
