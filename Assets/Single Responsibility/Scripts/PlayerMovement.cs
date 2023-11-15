using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [Header("Player Movement")]
    [SerializeField]
    private float speed=100f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovementFun();
    }


    void PlayerMovementFun()
    {
        float horzinput = Input.GetAxis("Horizontal");
        float vertInput = Input.GetAxis("Vertical");

        Vector3 movdir = new Vector3(horzinput, 0, vertInput);

        if(movdir!=null)
        {
           // Debug.Log("Moving");
            rb.velocity = movdir*speed*Time.deltaTime;   
        }
        else
        {
            Debug.Log("Stop Moving");
        }
    }
}
