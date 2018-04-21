using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{

    //Spawn The obstacle
    public GameObject spawnObject;

    public float maxTime = 10;
    public float minTime = 4;

    //current time
    private float time;

    //The time to spawn the obstacle
    private float spawnTime;

    void Start()
    {
        SetRandomTime();
        time = minTime;
    }

    void FixedUpdate()
    {

        //Count the time up
        time += Time.deltaTime;

        //Check if its the right time to spawn the obstacle
        if (time >= spawnTime)
        {
            SpawnObject();
            SetRandomTime();
        }

    }


    //Spawns the object and resets the time
    void SpawnObject()
    {
        time = 0;
        Instantiate(spawnObject, transform.position, spawnObject.transform.rotation);
    }

    //Sets the random time to spawn the obstacle between minTime and maxTime
    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }

}
