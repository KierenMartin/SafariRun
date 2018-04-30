using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collide : MonoBehaviour
{

	void OnCollisionEnter2D (Collision2D col)
    {
		if(col.gameObject.tag == "Obstacle")
        {
            // so this is sending a message to any other script on the same
            // game object to run a method called CollidedWithObject.  I
            // have created a method on AnimalController that receives this
            // message and does stuff.
            SendMessage("CollidedWithObject", col.collider);
        }

        if(col.gameObject.tag == "Enemy")
        {
            Debug.Log("Game Over");
            
            SendMessage("EndGame");
        }
    }
	
	
}
