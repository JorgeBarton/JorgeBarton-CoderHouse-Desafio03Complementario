using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurretFire_v01 : MonoBehaviour
{
    public GameObject bullet;
    public GameObject barrel;
    public float interva = 0.3f;
    public float delay = 0f;
    public bool shootReady = true;
    int numberOfbullets=0;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (shootReady)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                numberOfbullets = 2;
                InvokeRepeating("Fire", delay, interva);
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                numberOfbullets = 3;
                InvokeRepeating("Fire", delay, interva);
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                numberOfbullets = 4;
                InvokeRepeating("Fire", delay, interva);
            }
        }
    }

    public void Fire()
    {
        if (numberOfbullets != 0)
        {
            shootReady = false;
            Instantiate(bullet, barrel.transform);
            numberOfbullets--;
        }else
        {
            shootReady = true;
        }
    }
}
