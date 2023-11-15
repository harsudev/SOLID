using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    private void Start()
    {
        Charcater warrior = new Warrior();
        Charcater hulk= new Hulk();

        warrior.Attack();
        hulk.Attack();  
    }
}
