using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charcater
{
    public string Name { get; set; }
    public int Health { get; set; }

    public virtual void Attack()
    {
        //Base attack logic
        Debug.Log($"{Name} performs a basic Attack!");
    }
}


