using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScroller : MonoBehaviour
{
    [SerializeField] private float scrollSpeed;
    [SerializeField] private float resetX;

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += Vector3.left * scrollSpeed * Time.deltaTime;

        if (transform.localPosition.x < resetX)
        {
            transform.localPosition += Vector3.right * resetX;
        }
    }
}
