using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Move();
		
	}
	void Move(){
		//自分のy位置をマイナス方向に毎回「0.05f」ずつ移動させる。
		this.transform.position += new Vector3 (0, 0.05f, 0);
	}


	void PosishonChanger(){
		
		//移動させたいオブジェクトを登録。ここでは「Map」
		string NAME = "Main Camera";
		//tmpに位置情報を記憶させる。
		Vector3 tmp = GameObject.Find(NAME).transform.position;
		//tmpの位置情報を更新。ここではxをプラス100する。
		tmp = new Vector3(tmp.x + 100, tmp.y, tmp.z);


	}

}
