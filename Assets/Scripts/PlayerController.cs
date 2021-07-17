using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Joystick _joystick;
    private Rigidbody2D _playerRB; 

    private void Start()
    {
        _playerRB = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        if (Mathf.Abs(_joystick.Horizontal) > Mathf.Abs(_joystick.Vertical) && 
            _joystick.Horizontal > 0.5f &&
            transform.localPosition.x < 600)
        {
            _playerRB.MovePosition(new Vector2(transform.position.x + 3, transform.position.y));
        }
        else if(Mathf.Abs(_joystick.Horizontal) > Mathf.Abs(_joystick.Vertical) &&
            _joystick.Horizontal < -0.5f &&
            transform.localPosition.x > -600)
        {
            _playerRB.MovePosition(new Vector2(transform.position.x - 3, transform.position.y));
        }
        else if (Mathf.Abs(_joystick.Horizontal) < Mathf.Abs(_joystick.Vertical) && 
            _joystick.Vertical > 0.5f &&
            transform.localPosition.y < 350)
        {
            _playerRB.MovePosition(new Vector2(transform.position.x, transform.position.y + 3));
        }
        else if (Mathf.Abs(_joystick.Horizontal) < Mathf.Abs(_joystick.Vertical) &&
            _joystick.Vertical < -0.5f &&
            transform.localPosition.y > -350)
        {
            _playerRB.MovePosition(new Vector2(transform.position.x, transform.position.y - 3));
        }
    }
}
