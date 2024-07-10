using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    [SerializeField] private float flapStrength;
    public bool IsGameOver = false;
    [SerializeField] private GameObject deathScreen;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsGameOver) {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
            {
                rigidBody.velocity = Vector3.up * flapStrength;
            }
            if (Mathf.Abs(transform.position.y) > 6)
            {
                EndGame();
            }
        }
    }

    /// <summary>
    /// Triggers death screen.
    /// </summary>
    public void EndGame()
    {
        IsGameOver = true;
        deathScreen.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6) //Pipe layer
        {
            EndGame();
        }
    }
}
