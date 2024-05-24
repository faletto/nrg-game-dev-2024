using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    private float pipeSpeed;

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
