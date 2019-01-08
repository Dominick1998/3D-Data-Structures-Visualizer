using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stack : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void add(){
		GameObject[] stackArr = GameObject.FindGameObjectsWithTag("stack");
		if (stackArr.Length < 7) {
			GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
			cube.tag = "stack";
			cube.name = "Cube" + stackArr.Length;
			cube.transform.position = new Vector3 (0f, 7f, -7.65f);
			cube.transform.localScale = new Vector3 (1f, 0.3f, 0.5f);
			cube.AddComponent<Rigidbody> ();
			Renderer rend = cube.GetComponent<Renderer> ();
			rend.material.color = new Color (Random.Range (0f, 1f), Random.Range (0f, 1f), Random.Range (0f, 1f));
		}
	}

	public void remove(){


		//Debug.Log (GameObject.FindGameObjectWithTag("ground"));
		//DestroyObject (GameObject.FindGameObjectWithTag("ground"));

		GameObject[] stackArr = GameObject.FindGameObjectsWithTag("stack");
		if (stackArr.Length > 0) {
			DestroyObject (stackArr[stackArr.Length-1]);
		}
	}
}
