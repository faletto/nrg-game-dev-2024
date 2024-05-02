using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
    }

    // Update is called once per frame
    IEnumerator Spawn()
    {
        Instantiate(Enemy,GetComponent<BoxCollider2D>().bounds.center,new Quaternion());
        yield return new WaitForSeconds(2);
        StartCoroutine(Spawn());
    }
}
