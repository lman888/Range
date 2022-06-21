using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBullet : MonoBehaviour
{
    [SerializeField]
    private float _bulletSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FiredBullet();
    }

    /* Runs when bullet has been instantiated by the Gun script and has it travel forward */
    void FiredBullet()
    {
        transform.position += transform.forward * _bulletSpeed * Time.deltaTime;
    }
}
