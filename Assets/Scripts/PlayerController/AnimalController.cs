using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour {

    // collision delay is how long the collision should continue for
    // before we put an end to it and temporarily deactivate the collider
    public float CollisionDelay;
    public Vector2 KnockBack;


    public float collisionCountdown = 0f;
    public bool hasCollided = false;

    private Rigidbody2D animalPhysics;
    private Collider2D collidedObject;
    private bool running = true;
    private Collide collideState;

	// Use this for initialization
	private void Start () {
        animalPhysics = GetComponent<Rigidbody2D>();
        collideState = GetComponent<Collide>();
	}
	
	// Update is called once per frame
	private void LateUpdate () {
        if (running == false && collideState.Grounded)
        {
            //collisionCountdown -= Time.deltaTime;
            running = true;
            GetComponent<Animator>().speed = 1;
        }
        /*else if (hasCollided)
        {
            hasCollided = false;
            running = true;
            collidedObject.enabled = false;
            collisionCountdown = 0;
        }*/
	}

    public void CollidedWithObject(Collider2D objCollider)
    {
        //hasCollided = true;
        running = false;
        collisionCountdown = CollisionDelay;
        objCollider.GetComponent<Collider2D>().enabled = false;
        GetComponent<Animator>().speed = 0;
        animalPhysics.velocity = KnockBack;
    }

    public bool AnimalRunning {
        get {
            return this.running;
        }
    }
}
