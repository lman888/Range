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
            /* Spawns the bullet and has its forward vec the same as the guns forward vec */
            GameObject _projectile = Instantiate(_bullet, _bulletSpawn);

            _projectile.transform.position = transform.position + transform.forward;
        }
    }
}
