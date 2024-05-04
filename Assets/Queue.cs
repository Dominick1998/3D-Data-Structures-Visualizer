using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Manages the visualization and interaction of the queue data structure.
public class Queue : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
			SceneManager.LoadScene("HomeScene");
	}
 // Adds a new element to the end of the queue.
	public void add(){
		  // Find all game objects tagged as 'queue'.
		GameObject[] queueArr = GameObject.FindGameObjectsWithTag("queue");
		 // Limit queue to 7 elements for visibility and manageability.
		if (queueArr.Length < 7) {
			 // Create a new cube to represent the new queue element.
			GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
			cube.tag = "queue";
			cube.name = "Cube" + queueArr.Length;
			cube.transform.position = new Vector3 (0f, 7f, -7.65f);
			cube.transform.localScale = new Vector3 (1f, 0.3f, 0.5f);
			 // Add physics to the cube.
			cube.AddComponent<Rigidbody> ();
			  // Set a random color for visual distinction.
			Renderer rend = cube.GetComponent<Renderer> ();
			rend.material.color = new Color (Random.Range (0f, 1f), Random.Range (0f, 1f), Random.Range (0f, 1f));
		}
	}
  // Removes the oldest element from the front of the queue.
	public void remove(){
  // Find all game objects tagged as 'queue'.

		//Debug.Log (GameObject.FindGameObjectWithTag("ground"));
		//DestroyObject (GameObject.FindGameObjectWithTag("ground"));

		GameObject[] queueArr = GameObject.FindGameObjectsWithTag("queue");
		// Ensure there is at least one element to remove.
		if (queueArr.Length > 0) {
			  // Remove the first element (oldest in the queue).
			DestroyObject (queueArr[0]);
		}
	}
 // Method to navigate back to the main menu.
	public void back(){
		SceneManager.LoadScene("HomeScene");
	}
}
