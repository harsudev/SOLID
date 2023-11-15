using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    [Header("Enemy Path Container")]
    public List<Transform> path=new List<Transform>();

    private Rigidbody rb;
    public int currentWavePoint = 0;

    [Header("Debug Section")]
    public GameObject sphere;


    //Path Generator

    private void Start()
    {
        GenerateAiRandomPath();
    }

    private void Update()
    {
        MoveEnemytoPath();  
    }

    void GenerateAiRandomPath()
    {
        Vector3 startPos = transform.position;
        for(int i=0;i<10;i++)
        {
            Vector3 a = new Vector3(Random.Range(0,10), 0, Random.Range(0, 10));
            
            GameObject pathsphere=Instantiate(sphere,new Vector3(a.x,0,a.z),Quaternion.identity);
            path.Add(pathsphere.transform);
        }
    }

    void MoveEnemytoPath()
    {
        Vector3 dir = path[currentWavePoint].position - transform.position;
        while(currentWavePoint<10)
        {
            transform.Translate(dir);
        }
        
        
    }
}
