using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBullet : MonoBehaviour,IBullet
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    public void Hit()
    {
        Debug.Log("Bullet Hit Something");
    }

    public void MoveForward()
    {
        rb.velocity = new Vector3(0, 0, 10f);
    }

    
    // Update is called once per frame
    void Update()
    {
        MoveForward();
        Hit();
    }
}
