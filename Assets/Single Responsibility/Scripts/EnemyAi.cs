using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    [Header("Enemy Path Container")]
    public List<Transform> path=new List<Transform>();

    private Rigidbody rb;
    public int currentWavePoint = 0;
    public float enemySpeed = 10f;
    public float stoptime;
    public float timepointer;

    [Header("Debug Section")]
    public GameObject sphere;


    //Path Generator

    private void Start()
    {
        GenerateAiRandomPath();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I)) {
            currentWavePoint++;
        }
       MoveEnemytoPath();  
    }

    void GenerateAiRandomPath()
    {
        Vector3 startPos = transform.position;
        for(int i=0;i<10;i++)
        {
        
            
            GameObject pathsphere=Instantiate(sphere, new Vector3(startPos.x+Random.Range(0, 10), transform.position.y, startPos.z+Random.Range(0, 10)), Quaternion.identity);
            path.Add(pathsphere.transform);
        }
    }

    void MoveEnemytoPath()
    {
        Vector3 dir = path[currentWavePoint].position - transform.position;
        if(currentWavePoint<path.Count)
        {
            Debug.Log(dir.magnitude);
            if(dir.magnitude<=2f)
            {
                timepointer += Time.deltaTime;
                if(timepointer>=stoptime)
                {
                    currentWavePoint++;
                    timepointer = 0;
                }
          
            }
            else
            {
                transform.Translate(dir * enemySpeed * Time.deltaTime);
            }

           
        }
        else
        {
            currentWavePoint = 0;   
        }
        
       
    }
}
