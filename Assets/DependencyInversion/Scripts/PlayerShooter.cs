using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooter : MonoBehaviour,IShooter
{
    public GameObject bullet;
    public Transform shootingPos;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        Instantiate(bullet, shootingPos.position, Quaternion.identity);    
    }

    
}
