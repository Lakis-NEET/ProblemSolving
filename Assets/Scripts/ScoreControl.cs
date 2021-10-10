using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreControl : MonoBehaviour
{
    public static int score;

    [Header("Over")]
    public GameObject owari;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    private void Update()
    {
        if (score >= 20)
        {
            Over();
        }
    }
    private void Over()
    {
        owari.SetActive(true);
    }
}
