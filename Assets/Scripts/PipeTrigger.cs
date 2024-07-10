using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeTrigger : MonoBehaviour
{
    private Bird player;
    private Collider2D playerCollider;
    private ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Bird>();
        playerCollider = player.GetComponent<Collider2D>();
        scoreManager = FindObjectOfType<ScoreManager>();
        Debug.Log(scoreManager == null);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!player.IsGameOver && playerCollider == other)
        {
            scoreManager.AddScore();
        }
    }
}
