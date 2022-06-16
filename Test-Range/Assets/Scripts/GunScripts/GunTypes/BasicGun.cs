using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicGun : MonoBehaviour
{
    /* The bullet this gun will use */
    [SerializeField]
    private Transform _bullet;
    [SerializeField]
    private Transform _bulletSpawn;


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
            Instantiate(_bullet, _bulletSpawn);
        }
    }
}
