using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIBgEdGroup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        Rect rect = new Rect(Screen.width/2-200,Screen.height/2-100,400,200);
        GUI.BeginGroup(rect);
        GUI.Box(new Rect(0,0,400,200),"This box is now centered");
        GUI.EndGroup();
    }
}
