using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingHandler : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shotPos1;
    public Transform shotPos2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {

            Instantiate(bulletPrefab, shotPos1.position, Quaternion.identity);
            Instantiate(bulletPrefab, shotPos2.position, Quaternion.identity);

        }
    }
}
