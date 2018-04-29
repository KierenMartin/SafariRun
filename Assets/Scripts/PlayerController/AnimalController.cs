using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour {

    // collision delay is how long the collision should continue for
    // before we put an end to it and temporarily deactivate the collider
    public float CollisionDelay;


    public float collisionCountdown = 0f;
    public bool hasCollided = false;

    private Rigidbody2D animalPhysics;
    private Collider2D collidedObject;
    private bool running = true;

	// Use this for initialization
	private void Start () {

	}
	
	// Update is called once per frame
	private void Update () {
		if (collisionCountdown > 0)
        {
            collisionCountdown -= Time.deltaTime;
        }
        else if (hasCollided)
        {
            hasCollided = false;
            running = true;
            collidedObject.enabled = false;
            collisionCountdown = 0;
        }
	}

    public void CollidedWithObject(Collider2D objCollider)
    {
        hasCollided = true;
        running = false;
        collisionCountdown = CollisionDelay;
        collidedObject = objCollider;

    }

    public bool AnimalRunning {
        get {
            return this.running;
        }
    }
}
