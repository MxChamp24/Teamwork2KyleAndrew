using UnityEngine;
using System.Collections;

public class StartController : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	void OnGUI () {
		// Make a background box
		GUI.Box(new Rect(Screen.width/2-200,50,400,350), "Start Menu");
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		if(GUI.Button(new Rect(Screen.width/2-160,160,320,80), "Play Game")) {
			Application.LoadLevel(2);
		}
		if(GUI.Button (new Rect(Screen.width/2-160,260,320,80), "Instructions")) {
			Application.LoadLevel(1);
		}
	}
	
}
