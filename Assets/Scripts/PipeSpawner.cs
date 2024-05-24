using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private Pipe pipePrefab;
    [SerializeField] private float pipeSpeed;
    [SerializeField] private float pipeOffset;
    [SerializeField] private float timePerPipe;
    private float spawnTick = 0;

    // Update is called once per frame
    void Update()
    {
        if (spawnTick > 0)
        {
            spawnTick -= Time.deltaTime;
        }
        else
        {
            spawnTick = timePerPipe;
            Pipe pipe = Instantiate(pipePrefab);
            pipe.Initialize(pipeOffset, pipeSpeed);
        }
    }
}
