using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 worldPos = this.transform.position;
        Camera camera = Camera.main;
        Vector3 viewportPos = camera.WorldToViewportPoint(worldPos);

        if(viewportPos.y<-0.1 || 2 < viewportPos.y)
        {
            Destroy(this.gameObject);

        }
	}
}
