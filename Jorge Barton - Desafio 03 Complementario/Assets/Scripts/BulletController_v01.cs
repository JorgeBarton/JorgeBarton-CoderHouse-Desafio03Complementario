using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController_v01 : MonoBehaviour
{
    public float bulletSpeed = 10;
    public float damage = 10;
    public Vector3 bulletDirection=Vector3.forward;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( bulletDirection * bulletSpeed * Time.deltaTime);
    }
}
