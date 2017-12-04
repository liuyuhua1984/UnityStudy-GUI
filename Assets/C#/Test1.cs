using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        GUI.color = Color.yellow;
        Rect rect = new Rect(Screen.width/10,Screen.height/10,Screen.width/5,Screen.height/10);

        GUI.Label(rect,"Hello World!");
        rect = new Rect(Screen.width / 10, Screen.height / 5, Screen.width / 5, Screen.height / 5);
        GUI.Box(rect,"A Box");
        rect = new Rect(Screen.width/10,Screen.height/2,Screen.width/5,Screen.height/10);
        GUI.Button(rect,"A Button");
    }
}
