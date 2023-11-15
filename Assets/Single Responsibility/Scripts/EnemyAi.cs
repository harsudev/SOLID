using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    [Header("Enemy Path Container")]
    public List<Transform> path=new List<Transform>();

    private Rigidbody rb;   

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
        Vector3 startpos = transform.position;
        for(int i=0;i<10;i++)
        {
            Vector3 wavepointpos=startpos+new Vector3(Random.Range(1,10),transform.position.y,Random.Range(1,10));
            GameObject wavepointobject = new GameObject("WavePoint" + i);
            wavepointobject.transform.position = wavepointpos;
            path.Add(wavepointobject.transform);
            Instantiate(sphere, wavepointobject.transform.position, Quaternion.identity);
        }
    }

    void MoveEnemytoPath()
    {

        if(path.Count>0)
        {
            for (int i = 0; i < path.Count; i++)
            {
                transform.position = Vector3.Lerp(transform.position, path[i].position, 10);
                if(i==10)
                {
                    i = 0;
                }
            }
        }
        
    }
}
