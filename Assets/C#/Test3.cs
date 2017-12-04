using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        GUI.contentColor = Color.yellow;
        GUI.Button(new Rect(Screen.width/10,Screen.height/10,Screen.width/5,Screen.height/10),"A   Button");
    }
}
