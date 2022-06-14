using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Basic Movement Class for the Player
    [SerializeField]
    float _playerSpeed;

    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
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
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * _playerSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * _playerSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * _playerSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * _playerSpeed * Time.deltaTime, Space.World);
        }
        #endregion

        #region Rotation Based-Movement
        /* Obtains the Horozontal and Vertical Axis's */
        //float _horizontalInput = Input.GetAxis("Horizontal");
        //float _verticalInput = Input.GetAxis("Vertical");

        /* Obtains a new movement Direction */
        //Vector3 _movementDirection = new Vector3(_horizontalInput, 0.0f, _verticalInput);
        //_movementDirection.Normalize();

        //transform.Translate(_movementDirection * _playerSpeed * Time.deltaTime, Space.World);

        //if (_movementDirection != Vector3.zero)
        //{
        //    transform.forward = _movementDirection;
        //}
        #endregion

    }
}
