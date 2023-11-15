using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    public GameObject cube;

    public override void Draw()
    {
        GameObject cubee = Instantiate(cube,transform.position,Quaternion.identity);
        cube.transform.Rotate(0, 0, 10f);
    }
}
