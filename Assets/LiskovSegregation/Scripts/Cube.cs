using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    public GameObject cube;

    public override void Draw()
    {
        Debug.Log("Draw a Cube shape");
    }
}
