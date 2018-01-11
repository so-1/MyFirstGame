using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{

    //public GameObject[] enemyList;
    public GameObject enemy;
    //private bool TimerScore;


    // Use this for initialization
    void Start()
    {
        


        InvokeRepeating("EnemyAppend", 1.0f,0.3f);
          
    }

    // Update is called once per frame
    void Update()
    {

    }

    void EnemyAppend()
    {

        GameObject obj = enemy;

        Vector3 pos = new Vector3(0, 0, 0);
        pos = GameObject.Find("CLOUD").transform.position;
        
        Instantiate(obj, pos, Quaternion.identity);

    }
}
