using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LManager : MonoBehaviour
{

    private void Start()
    {
        Shape myshape= new Shape();
        Shape myshape2 = new Cube();
        Shape myshape3 = new Capsule();
        Shape myshape4 = new Circle();

        myshape.Draw();
        myshape2.Draw();
        myshape3.Draw();
        myshape4.Draw();
        myshape3.Draw();


    }
}
