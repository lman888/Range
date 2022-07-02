using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicGun : MonoBehaviour
{
    /* The bullet this gun will use */
    [SerializeField]
    private GameObject _bullet;
    [SerializeField]
    private Transform _bulletSpawn;
    [SerializeField]
    private float _bulletSpeed;
    [SerializeField]
    private float _shootPower;

    [SerializeField]
    Camera _cam;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FireGun();
    }

    void FireGun()
    {
        /* Funily enough, this fires the gun */
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            /* Just a ray that goes through the middle of your screen */
            Ray _ray = _cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.0f));
            RaycastHit _hit;

            Vector3 _targetPoint;
            if (Physics.Raycast(_ray, out _hit))
            {
                _targetPoint = _hit.point;
            }
            else
            {
                /* Pointer away from the player */
                _targetPoint = _ray.GetPoint(75);
            }

            Vector3 _direction = _targetPoint - _bulletSpawn.position;

            /* Spawns the bullet and has its forward vec the same as the guns forward vec */
            GameObject _projectile = Instantiate(_bullet, _bulletSpawn.position, Quaternion.identity);

            _projectile.transform.forward = _direction.normalized;

            _projectile.GetComponent<Rigidbody>().AddForce(_direction.normalized * _shootPower, ForceMode.Impulse);
        }
    }
}
