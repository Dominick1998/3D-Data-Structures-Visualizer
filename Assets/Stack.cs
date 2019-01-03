using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stack : MonoBehaviour {
	public Material[] material;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void add(){
		GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube.transform.position = new Vector3 (0f, 7f, -7.65f);
		cube.transform.localScale = new Vector3 (0.7f, 0.05f, 0.7f);
		cube.AddComponent<Rigidbody> ();
		Renderer rend = cube.GetComponent<Renderer> ();
		rend.material.color = new Color (Random.Range(0f,1f), Random.Range(0f,1f), Random.Range(0f,1f));
	}

	public void remove(){

	}
}
