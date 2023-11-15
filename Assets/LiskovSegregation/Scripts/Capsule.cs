using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    public GameObject capsule;
    public override void Draw()
    {
        GameObject cap=Instantiate(capsule, transform.position, Quaternion.identity);
        cap.transform.Rotate(0, 2, 0);
    }
}
