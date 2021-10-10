using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDestroy : MonoBehaviour
{
    public float gap = 3f;
    private float timer = 0;
    public bool Tabrak = false;
    public Collider2D col;
    public AudioSource Soundpoin;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            ScoreControl.score += 1;
            //gameObject.SetActive(false);
            transform.localScale = Vector3.zero;
            Tabrak = true;
            col.enabled = false;
            Soundpoin.PlayOneShot(Soundpoin.clip);
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
                if (BoxSpawn.Instance.respawnallow)
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
}
