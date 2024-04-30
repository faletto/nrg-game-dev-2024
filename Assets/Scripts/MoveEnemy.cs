using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    private int enemySpeed;
    private Rigidbody2D enemyBody;
    private Collider2D enemyCollider;
    private Collider2D playerCollider;
    // Start is called before the first frame update
    void Start()
    {
        enemyBody = GetComponent<Rigidbody2D>();
        enemySpeed = 5;
        enemyCollider = GetComponent<Collider2D>();
        playerCollider = GameObject.Find("Player").GetComponent<Collider2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyBody.velocity = new Vector2(enemySpeed, enemyBody.velocity.y);

        if (transform.position.x > 8.25)
        {
            Destroy(transform.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider == playerCollider)
        {
            if (playerCollider.bounds.center.y > enemyCollider.bounds.center.y)
            {
                Debug.Log("Player on top");
                Destroy(transform.gameObject);
            }
            else {
                Debug.Log("Enemy on top");
                // End the game
            }
            
        }
    }
}
