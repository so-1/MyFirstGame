using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        

	}
	
	// Update is called once per frame
	void Update () {
        Move2();
	}

    void Move2()
    {
        
        float moveY = 0.01f;
        this.transform.position += new Vector3(0, moveY, 0);
    }
}
