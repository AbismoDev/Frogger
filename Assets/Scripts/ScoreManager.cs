using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text contador_;
    public int score;

    // Update is called once per frame
    void Update()
    {
        contador_.text = score.ToString();
    }
}
