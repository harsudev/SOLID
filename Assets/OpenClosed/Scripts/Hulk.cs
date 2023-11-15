using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hulk : Charcater
{
    public Hulk()
    {
        Name = "Hulk";
        Health = 90;
    }
    public override void Attack()
    {
        Debug.Log($"{Name} Throw a hammer");
    }
}
