using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [SerializeField]
    public int speed;
    [SerializeField]
    public LayerMask ground;
    private Rigidbody2D playerBody;
    private Collider2D playerCollider;
    // Start is called before the first frame update
    void Start()
    {
        playerCollider = GetComponent<Collider2D>();
        playerBody = GetComponent<Rigidbody2D>();
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        // This Controls Player Movement left and right
        playerBody.velocity = new Vector2(speed*Input.GetAxis("Horizontal"),playerBody.velocity.y);
        
        if (Input.GetKey(KeyCode.UpArrow)) { Jump(); }
    }

    void Jump()
    {
        // This is the most complicated part of the entire code, and you may want to skip over this. Essentially, it casts a line straight downward to make sure there's nothing below it.
        RaycastHit2D platformBelow = Physics2D.BoxCast(playerCollider.bounds.center, playerCollider.bounds.size, 0, Vector2.down, 0.1f,ground);
        if (platformBelow.collider != null)
        {
            playerBody.velocity = new Vector2(playerBody.velocity.x, 15);
        }
    }
}
