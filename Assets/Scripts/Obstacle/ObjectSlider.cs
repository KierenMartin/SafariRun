using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSlider : MonoBehaviour {
    public int Speed; // how fast is the object going to slide

	private void Update()
	{
        // we want the object to slide from right to left.  We also want
        // to do it at a speed that is constant no matter what the "framerate"
        // is.  Each time the picutre is redrawn on the screen a new frame
        // ocurres and every Update() method on all gameplay objects is called.
        // this can happen with different amounst of delay, so we want to make
        // sure that we find out how much time has passed since the last time
        // Updaet() was called.  We do this with Time.deltaTime

        float delay = Time.deltaTime;

        // we now multiply speed with deltaTime to find out how far it should
        // have moved between frame one and this frame.  Ultimately this means
        // that speed is now many "Unity World Units" the object will move in
        // one second.

        float distanceMoved = Speed * delay;

        // now we actually have to move it.  Every game object in a scene has a
        // transform class to say where it is and how it can be moved.  transform
        // also has a method Translate which moves the game object a certain
        // distance using a "Vector 3" <x, y, z>  so the first number is how
        // many world units on the x axis to move the object. 

        // In the line below I'm moving the object by negativedistanceMoved on
        // x axis and 0 world units on the y and the z axes (up and towards/away)
        transform.Translate(new Vector3(-distanceMoved, 0, 0));

        // this should be all wee need to do to slide an object accross the screen
	}
}
