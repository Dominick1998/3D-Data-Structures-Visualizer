using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Manages the main menu and scene transitions within the application.
public class Home : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) 
			Application.Quit(); // quit the app on phone
	}
 // Loads the Queue scene when the corresponding UI button is clicked.
	public void queueOnClick(){
		SceneManager.LoadScene("QueueScene");
	}
 // Loads the Stack scene when the corresponding UI button is clicked.
	public void stackOnClick(){
		SceneManager.LoadScene("StackScene");
	}
 // Loads the Linked List scene when the corresponding UI button is clicked.
	public void linkedlistOnClick(){
		SceneManager.LoadScene("LinkedListScene");
	}
 // Loads the Binary Search Tree scene when the corresponding UI button is clicked.
	public void bstOnClick(){
		SceneManager.LoadScene("BSTScene");
	}
}
