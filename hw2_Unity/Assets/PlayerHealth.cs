using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
	public float health;
	public Slider healthslider;
	// Use this for initialization
	void Start () {
		
	}
	void Update () {
	}
	void OnCollisionEnter (Collision collision) {//碰撞發生時呼叫
		//碰撞後產生爆炸
		
		if (collision.gameObject.tag == "bullet") {
			health = health - 10;
			healthslider.value = health;
		}
		if (health <= 0)
			Destroy (this.gameObject);
		
	}
}
// Update is called once per frame


