using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleRemover : MonoBehaviour
{
    //Set a time in inspector to delete the obstacle
    public float lifetime;
    //Destroy the obstacle after the given time
    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}
