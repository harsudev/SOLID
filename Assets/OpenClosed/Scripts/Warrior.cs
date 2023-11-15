using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior:Charcater
{
    public Warrior()
    {
        Name = "Warrior";
        Health = 100;
    }

    public override void Attack()
    {
        Debug.Log($"{Name} swings a sword");
    }
}
    

