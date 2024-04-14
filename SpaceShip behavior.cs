using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    private bool _moveRight;
    private bool _moveLeft;
    
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
            transform.position += Vector3.right * (50 * Time.deltaTime);
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
            transform.position += Vector3.left * (50 * Time.deltaTime);
        } 
    }
    
}
