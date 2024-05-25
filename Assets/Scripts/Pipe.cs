using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    private float pipeSpeed;

    /// <summary>
    /// Initializes pipe prefab parameters.
    /// </summary>
    /// <param name="offset"></param> The maximum vertical distance from the pipe and the starting point.
    /// <param name="speed"></param> The speed at which the pipe moves horizontally.
    public void Initialize(float offset, float speed)
    {
        pipeSpeed = speed;
        transform.position = new Vector3(10, Random.Range(-offset, offset), 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * pipeSpeed;

        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
