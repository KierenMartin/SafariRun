using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{

	void OnCollisionEnter2D (Collision2D col)
    {
		if(col.gameObject.tag == "Obstacle")
        {
            SendMessage("CollidedWithObject");
        }

        if(col.gameObject.tag == "Enemy")
        {
            Debug.Log("Game Over");

        }
    }
	
	
}
