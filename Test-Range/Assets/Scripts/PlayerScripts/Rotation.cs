using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    private Transform _playerObject;
    [SerializeField]
    private float _senstivity;
    
    /* Looking Constraints */
    [SerializeField]
    private float _lookingUpConstraint;
    [SerializeField]
    private float _lookingDownConstraint;


    private float _mouseY;
    private float _mouseX;
    private float _xRotation = 0.0f;

    // Update is called once per frame
    void Update()
    {
        MouseRotation();
    }

    void MouseRotation()
    {
        /* Gets the rotation based on the mouse position */
        _mouseX = Input.GetAxis("Mouse X") * _senstivity * Time.deltaTime;
        _mouseY = Input.GetAxis("Mouse Y") * _senstivity * Time.deltaTime;

        /*Allows to look up/down and smooths out the rotation of the player*/
        _xRotation -= _mouseY;
        /* Clamps the Mouse Rotation */
        _xRotation = Mathf.Clamp(_xRotation, _lookingUpConstraint, _lookingDownConstraint);

        /* Rotates both the camera rotation and the players body rotation */
        transform.localRotation = Quaternion.Euler(_xRotation, 0.0f, 0.0f);
        _playerObject.Rotate(Vector3.up * _mouseX);

    }
}
