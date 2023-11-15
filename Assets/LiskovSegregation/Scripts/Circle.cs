using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Circle : Shape
{
   public GameObject circle;
    public override void Draw()
    {

        GameObject cir=Instantiate(circle,transform.position,transform.rotation);
        cir.transform.Rotate(10, 0, 0);
    }
}
