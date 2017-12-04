using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test9 : MonoBehaviour {

    public static int guiDepth = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        GUI.depth = guiDepth;
        if (GUI.RepeatButton(new Rect(Screen.width/10,Screen.height/10,Screen.width/5,Screen.height/5),"GoBack"))
        {
            guiDepth = 1;
            Test10.guiDepth = 0;
        }
    }
}
