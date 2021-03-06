using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private CharacterController _controller;

    //Basic Movement Class for the Player
    [SerializeField]
    float _playerSpeed;
    [SerializeField]
    private float _jumpHeight;

    private bool _groundedPlayer;
    private Vector3 _playerVelocity;
    /* Earths natural gravity value */
    private float _gravityValue = -9.81f;

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        #region RigidBody-Movement
        ////Dragged Movement
        //if (Input.GetKey(KeyCode.A))
        //{
        //    _rb.AddForce(Vector3.left * _playerSpeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    _rb.AddForce(Vector3.right * _playerSpeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.W))
        //{
        //    _rb.AddForce(Vector3.forward * _playerSpeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    _rb.AddForce(Vector3.back * _playerSpeed * Time.deltaTime);
        //}
        #endregion

        #region Instant-Movement
        //Instant Movement
        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.Translate(Vector3.left * _playerSpeed * Time.deltaTime, Space.World);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(Vector3.right * _playerSpeed * Time.deltaTime, Space.World);
        //}
        //if (Input.GetKey(KeyCode.W))
        //{
        //    transform.Translate(Vector3.forward * _playerSpeed * Time.deltaTime, Space.World);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(Vector3.back * _playerSpeed * Time.deltaTime, Space.World);
        //}
        #endregion

        #region Rotation Based-Movement
        /* Obtains the Horozontal and Vertical Axis's */
        float _x = Input.GetAxis("Horizontal");
        float _z = Input.GetAxis("Vertical");

        Vector3 _move = transform.right * _x + transform.forward * _z;

        _controller.Move(_move * _playerSpeed * Time.deltaTime);


        //_groundedPlayer = _controller.isGrounded;
        if (_groundedPlayer && _playerVelocity.y <= 0)
        {
            _playerVelocity.y = 0.0f;
        }

        if (Input.GetButtonDown("Jump") && _groundedPlayer)
        {
            _playerVelocity.y += Mathf.Sqrt(_jumpHeight * -3.0f * _gravityValue);
        }

        _playerVelocity.y += _gravityValue * Time.deltaTime;
        _controller.Move(_playerVelocity * Time.deltaTime);

        #endregion

    }
}
