using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDestroy : MonoBehaviour
{
    public float gap = 3f;
    private float timer = 0;
    public bool Tabrak = false;
    public Collider2D col;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Dot") 
        {
            ScoreControl.score += 1;
            //gameObject.SetActive(false);
            transform.localScale = Vector3.zero;
            Tabrak = true;
            col.enabled = false;
        }
    }
    private void Update()
    {
        if (Tabrak)
        {
            if (timer < gap)
            {
                timer += Time.deltaTime;
            }
            else
            {
                transform.position = BoxSpawn.Instance.DaerahSpawn();
                transform.localScale = Vector3.one;
                Tabrak = false;
                timer = 0;
                col.enabled = true;
            }
        }
    }
}
