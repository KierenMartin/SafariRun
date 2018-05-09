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
<<<<<<< HEAD
    AudioSource audio;

    // Use this for initialization
    private void Start () {
        audio = GetComponent<AudioSource>();
    }
=======
    private Collide collideState;

	// Use this for initialization
	private void Start () {
        animalPhysics = GetComponent<Rigidbody2D>();
        collideState = GetComponent<Collide>();
	}
>>>>>>> master
	
	// Update is called once per frame
	private void LateUpdate () {
        if (running == false && collideState.Grounded)
        {
            //collisionCountdown -= Time.deltaTime;
            running = true;
<<<<<<< HEAD
            collidedObject.enabled = false;
            collisionCountdown = 0;
            audio.Play();
=======
            GetComponent<Animator>().speed = 1;
>>>>>>> master
        }
	}

    public void CollidedWithObject(Collider2D objCollider)
    {
        //hasCollided = true;
        running = false;
        collisionCountdown = CollisionDelay;
<<<<<<< HEAD
        collidedObject = objCollider;
    
        audio.Stop();
=======
        objCollider.enabled = false;
        GetComponent<Animator>().speed = 0;
        animalPhysics.velocity = KnockBack;
>>>>>>> master
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
