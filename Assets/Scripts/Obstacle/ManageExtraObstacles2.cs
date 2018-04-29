using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageExtraObstacles2 : MonoBehaviour, IRecycle
{

    public Sprite[] sprites;

    public void Restart()
    {
        var renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = sprites[Random.Range(0, sprites.Length)];

    }


    public void Shutdown()
    {
        throw new System.NotImplementedException();
    }
}
