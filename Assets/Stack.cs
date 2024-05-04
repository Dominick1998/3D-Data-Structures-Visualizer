using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Manages the visualization and interaction of the stack data structure.
public class Stack : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
			SceneManager.LoadScene("HomeScene");
	}
  // Adds a new element to the top of the stack.
	public void add(){
		 // Find all game objects tagged as 'stack'.
		GameObject[] stackArr = GameObject.FindGameObjectsWithTag("stack");
		 // Limit stack to 7 elements for visibility and manageability.
		if (stackArr.Length < 7) {
			// Create a new cube to represent the new stack element.
			GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
			cube.tag = "stack";
			cube.name = "Cube" + stackArr.Length;
			cube.transform.position = new Vector3 (0f, 7f, -7.65f);
			cube.transform.localScale = new Vector3 (1f, 0.3f, 0.5f);
			 // Add physics to the cube.
			cube.AddComponent<Rigidbody> ();
			 // Set a random color for visual distinction.
			Renderer rend = cube.GetComponent<Renderer> ();
			rend.material.color = new Color (Random.Range (0f, 1f), Random.Range (0f, 1f), Random.Range (0f, 1f));
		}
	}
// Removes the top element from the stack.
	public void remove(){
 // Find all game objects tagged as 'stack'.

		//Debug.Log (GameObject.FindGameObjectWithTag("ground"));
		//DestroyObject (GameObject.FindGameObjectWithTag("ground"));

		GameObject[] stackArr = GameObject.FindGameObjectsWithTag("stack");
		   // Ensure there is at least one element to remove.
		if (stackArr.Length > 0) {
			DestroyObject (stackArr[stackArr.Length-1]);
		}
	}
// Method to navigate back to the main menu.
	public void back(){
		SceneManager.LoadScene("HomeScene");
	}
}
