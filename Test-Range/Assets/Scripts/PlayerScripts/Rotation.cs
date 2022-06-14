using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
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
        /* Gets the rotation based on the mouse position */
        _yaw += _senstivity * Input.GetAxis("Mouse X");
        _pitch += _senstivity * Input.GetAxis("Mouse Y");


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

        /* Creates a new Vector 3 and rotates the player accordingly */
        transform.eulerAngles = _lookDirection;

    }
}
