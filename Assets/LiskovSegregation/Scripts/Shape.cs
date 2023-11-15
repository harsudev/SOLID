using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public virtual void Draw()
    {
        Debug.Log("Draw a base shape");
    }
}
