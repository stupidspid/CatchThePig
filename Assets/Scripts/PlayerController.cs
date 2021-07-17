using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Joystick _joystick;
    [SerializeField] private GameObject _losePanel;
    private Rigidbody2D _playerRB; 

    private void Start()
    {
        _playerRB = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        if (Mathf.Abs(_joystick.Horizontal) > Mathf.Abs(_joystick.Vertical) && 
            _joystick.Horizontal > GlobalConstants.JOYSTICK_MOVE_FACTOR &&
            transform.localPosition.x < GlobalConstants.SIDE_LIMIT)
        {
            _playerRB.MovePosition(new Vector2(transform.position.x + GlobalConstants.PLAYER_MOVE_STEP, transform.position.y));
        }
        else if(Mathf.Abs(_joystick.Horizontal) > Mathf.Abs(_joystick.Vertical) &&
            _joystick.Horizontal < -GlobalConstants.JOYSTICK_MOVE_FACTOR &&
            transform.localPosition.x > -GlobalConstants.SIDE_LIMIT)
        {
            _playerRB.MovePosition(new Vector2(transform.position.x - GlobalConstants.PLAYER_MOVE_STEP, transform.position.y));
        }
        else if (Mathf.Abs(_joystick.Horizontal) < Mathf.Abs(_joystick.Vertical) && 
            _joystick.Vertical > GlobalConstants.JOYSTICK_MOVE_FACTOR &&
            transform.localPosition.y < GlobalConstants.UP_DOWN_LIMIT)
        {
            _playerRB.MovePosition(new Vector2(transform.position.x, transform.position.y + GlobalConstants.PLAYER_MOVE_STEP));
        }
        else if (Mathf.Abs(_joystick.Horizontal) < Mathf.Abs(_joystick.Vertical) &&
            _joystick.Vertical < -GlobalConstants.JOYSTICK_MOVE_FACTOR &&
            transform.localPosition.y > -GlobalConstants.UP_DOWN_LIMIT)
        {
            _playerRB.MovePosition(new Vector2(transform.position.x, transform.position.y - GlobalConstants.PLAYER_MOVE_STEP));
        }
    }

    private void OnDestroy()
    {
        _losePanel.SetActive(true);
    }
}
