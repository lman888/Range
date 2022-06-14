using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    private Transform _playerHead;

    [SerializeField]
    private float _senstivity;
    
    /* Looking Constraints */
    [SerializeField]
    private float _lookingUpConstraint;
    [SerializeField]
    private float _lookingDownConstraint;


    private float _pitch;
    private float _yaw;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MouseRotation();
    }

    void MouseRotation()
    {
        /* Sets the Camera Position to the Head of the Player */
        this.transform.position = _playerHead.position;

        /* Gets the rotation based on the mouse position */
        _yaw += _senstivity * Input.GetAxis("Mouse X");
        _pitch -= _senstivity * Input.GetAxis("Mouse Y");


        /* Locks the Down look rotation */
        if (_pitch >= _lookingDownConstraint)
        {
            _pitch = _lookingDownConstraint;
        }

        /* Locks the Up look rotation */
        if (_pitch <= _lookingUpConstraint)
        {
            _pitch = _lookingUpConstraint;
        }

        Vector3 _lookDirection = new Vector3(_pitch, _yaw, 0.0f);

        /* Creates a new Vector 3 and rotates Camera's position */
        transform.eulerAngles = _lookDirection;

        /* Rotates the Players Head */
        _playerHead.transform.eulerAngles = _lookDirection;
    }
}
