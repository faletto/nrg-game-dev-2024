using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeTrigger : MonoBehaviour
{
    private Collider2D playerCollider;

    // Start is called before the first frame update
    void Start()
    {
        playerCollider = FindObjectOfType<Bird>().GetComponent<Collider2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("SCORE!");
    }
}
