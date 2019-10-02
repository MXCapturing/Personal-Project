using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{
    public PlayerController _plCont;
    public GameObject boomerang;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            transform.localRotation = Quaternion.Euler(0, 0, 45);
        }
        else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localRotation = Quaternion.Euler(0, 0, 135);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            transform.localRotation = Quaternion.Euler(0, 0, 315);
        }
        else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localRotation = Quaternion.Euler(0, 0, 225);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.localRotation = Quaternion.Euler(0, 0, 90);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localRotation = Quaternion.Euler(0, 0, 180);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.localRotation = Quaternion.Euler(0, 0, 270);
        }
        else if (_plCont.plSprite.flipX)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 180);
        }
        else if (!_plCont.plSprite.flipX)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            _plCont.speed = 0;
        }
        else
        {
            _plCont.speed = 2;
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(boomerang, transform.position, transform.rotation);
        }
    }
}
