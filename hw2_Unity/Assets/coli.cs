using UnityEngine;
using System.Collections;

public class coli : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter (Collision collision) {//碰撞發生時呼叫
		//碰撞後產生爆炸
		
		//	if(collision.gameObject.tag == "enemy"){//當撞到的collider具有enemy tag時
		Destroy(gameObject);//刪除砲彈
		//	}
	}
}
