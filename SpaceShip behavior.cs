using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    private bool _moveRight;
    private bool _moveLeft;
    private int movement = 70;

    public GameObject laser;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -25, 0);
        _moveLeft = false;
        _moveRight = false;
    }

    // Update is called once per framed
    void Update()
    {
        MoveShip();
        ShootLaser();
    }

    private void MoveShip()
    {
        if (Input.GetKeyDown(KeyCode.D)| Input.GetKeyDown(KeyCode.RightArrow) )
        {
            _moveRight = true;
           
        }
        else if (Input.GetKeyUp(KeyCode.D) | Input.GetKeyUp(KeyCode.RightArrow))
        {
            _moveRight = false;
        }

        if (_moveRight & transform.position.x < 54.3)
        {
            transform.position += Vector3.right * (movement * Time.deltaTime);
        }
        
        if (Input.GetKeyDown(KeyCode.A) | Input.GetKeyDown(KeyCode.LeftArrow) )
        {
            _moveLeft = true;
           
        }
        else if (Input.GetKeyUp(KeyCode.A) | Input.GetKeyUp(KeyCode.LeftArrow))
        {
            _moveLeft = false;
        }

        if (_moveLeft & transform.position.x > -54.3)
        {
            transform.position += Vector3.left * (movement * Time.deltaTime);
        } 
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Asteroid")
        {
            Destroy(gameObject);
        }
    }

    private void ShootLaser()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 v = new Vector3(transform.position.x, -23f, 0);
            Instantiate(laser, v, quaternion.identity);
        }
    }
}
