using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    public GameObject capsule;
    public override void Draw()
    {
        Debug.Log("Draw a Capsule shape");
    }
}
