using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpaceScript : MonoBehaviour
{
    private UIManagerScript _uiManagerhandler;

    private BirdScript _birdhandler;

    private void Start()
    {
        _uiManagerhandler  = GameObject.Find("Canvas").GetComponent<UIManagerScript>();
        _birdhandler = GameObject.Find("Bird").GetComponent<BirdScript>();
    }


    private void OnTriggerEnter2D(Collider2D collisionObject)
    {
        if(_birdhandler.CheckIsBirdAlive() && collisionObject.tag=="Player")
        {

            _uiManagerhandler.AddScore();
            _uiManagerhandler.UpdateScore();
        }
    }
}
