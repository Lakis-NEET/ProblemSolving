using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScore : MonoBehaviour
{
    [SerializeField]
    public Text score;

    void Update()
    {
        score.text = ScoreControl.score.ToString("0");
    }
}
