using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test6 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        Rect rect = new Rect(Screen.width/10,Screen.height/10,Screen.width/5,Screen.height/10);
        GUI.Button(rect,new GUIContent("This is the tooltip"));

        GUI.Label(new Rect(Screen.width/10,Screen.height/5,Screen.width/5,Screen.height/10),GUI.tooltip);
    }
}
