using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverText : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnDisable()
    {
        GameObject.Find("Canvas").transform.Find("TextGAMEOVER").gameObject.SetActive(true);
    }

}
