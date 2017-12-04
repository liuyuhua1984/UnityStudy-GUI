using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        GUI.backgroundColor = Color.yellow;
        Rect rect = new Rect(Screen.width/10,Screen.height/10,Screen.width/5,Screen.height/10);
        GUI.Button(rect,"A Button");
    }
}
