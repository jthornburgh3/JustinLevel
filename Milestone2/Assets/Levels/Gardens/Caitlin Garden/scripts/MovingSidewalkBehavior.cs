using UnityEngine;
using System.Collections;

public class MovingSidewalkBehavior : MonoBehaviour {

	public float pallet_Length;
	public int pallet_Count;
	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void FixedUpdate () {
		
	}

	//capture an object when it reaches the moving sidewalk
	void OnTriggerStay (Collider captured) {
		captured.gameObject.transform.parent = this.transform.Find("Moving");
		Debug.Log ("entered trigger");
		Debug.Log ("captured object name is " + captured.name);
		Debug.Log ("new parent is " + this.transform.Find ("Moving").name);
	}

	void OnTriggerExit (Collider captured) {
		captured.gameObject.transform.parent = null;
	}
}
