using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeTrigger : MonoBehaviour
{
    private Collider2D playerCollider;
    private ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        playerCollider = FindObjectOfType<Bird>().GetComponent<Collider2D>();
        scoreManager = FindObjectOfType<ScoreManager>();
        Debug.Log(scoreManager == null);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (playerCollider == other)
        {
            scoreManager.AddScore();
        }
    }
}
