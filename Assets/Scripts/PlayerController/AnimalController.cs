using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimalController : MonoBehaviour {

    // collision delay is how long the collision should continue for
    // before we put an end to it and temporarily deactivate the collider
    public float CollisionDelay;
    public Vector2 KnockBack;
    public GameObject GameOverUI;

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
	}

    public void CollidedWithObject(Collider2D objCollider)
    {
        //hasCollided = true;
        running = false;
        collisionCountdown = CollisionDelay;
        objCollider.enabled = false;
        GetComponent<Animator>().speed = 0;
        animalPhysics.velocity = KnockBack;
    }

    public bool AnimalRunning {
        get {
            return this.running;
        }
    }

    public void EndGame()
    {
        GameOverUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void QuitLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start Screen");
    }

    public void RestartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Safari Run");
    }
}
