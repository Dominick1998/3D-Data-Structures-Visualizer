using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) 
			Application.Quit(); // quit the app on phone
	}

	public void queueOnClick(){
		SceneManager.LoadScene("QueueScene");
	}

	public void stackOnClick(){
		SceneManager.LoadScene("StackScene");
	}

	public void linkedlistOnClick(){
		SceneManager.LoadScene("LinkedListScene");
	}

	public void bstOnClick(){
		SceneManager.LoadScene("BSTScene");
	}
}
