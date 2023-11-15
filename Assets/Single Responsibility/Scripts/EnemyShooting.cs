using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shootingPos1;
    public Transform shootingPos2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("EnemyShoot", 2, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EnemyShoot()
    {
        Instantiate(bulletPrefab, shootingPos1.position, Quaternion.identity);
        Instantiate(bulletPrefab,shootingPos2.position, Quaternion.identity);   
    }
}
