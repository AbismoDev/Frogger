using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCount : MonoBehaviour
{

    ScoreManager score_manager;

    // Start is called before the first frame update
    void Start()
    {
        score_manager = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score_manager.score += 1;
    }
}
