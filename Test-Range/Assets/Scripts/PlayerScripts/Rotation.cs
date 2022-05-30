using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField]
    float _rotationSpeed;
    [SerializeField]
    float _cutoffAngle;


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
        /* Obtains the Mouse Position from the Center of the screen */
        Vector3 _mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 10.0f);

        float _angle = AngleBetweenPoints(transform.position, _mouseWorldPos);

        transform.rotation = Quaternion.Euler(new Vector3(_angle, _angle, 0));
    }

    float AngleBetweenPoints(Vector2 a, Vector2 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}
