using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class AnimalController : MonoBehaviour {

    // collision delay is how long the collision should continue for
    // before we put an end to it and temporarily deactivate the collider
    public float CollisionDelay;

    // InvulnerableTimer is how long the animal remains invulnerable to further
    // collisions.  Should be enough time for the object to get clear of the
    // animal.
    public float InvulnerableTimer;

    public float collisionCountdown = 0f;
    public bool hasCollided = false;
    public float invulnerableCountdown = 0f;

    private Rigidbody2D animalPhysics;

	// Use this for initialization
	private void Start () {
        animalPhysics = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	private void Update () {
		if (collisionCountdown > 0)
        {
            collisionCountdown -= Time.deltaTime;
        }
        else if (invulnerableCountdown > 0)
        {
            invulnerableCountdown -= Time.deltaTime;
        }
        else if (hasCollided)
        {
            hasCollided = false;
            invulnerableCountdown = InvulnerableTimer;
            animalPhysics.simulated = false;
        }
        else if (!animalPhysics.simulated)
        {
            animalPhysics.simulated = true;
            collisionCountdown = 0;
            invulnerableCountdown = 0;
        }
	}

    public void CollidedWithObject()
    {
        hasCollided = true;
        collisionCountdown = CollisionDelay;
    }
}
