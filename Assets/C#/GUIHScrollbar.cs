using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIHScrollbar : MonoBehaviour {
    public float hSbarValue;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        //绘制一个初始值为hSbarValue的水平滚动条
        hSbarValue = GUI.HorizontalScrollbar(new Rect(Screen.width/10,Screen.height/10,Screen.width/3,Screen.height/10),hSbarValue,1.0f,0.0f,10.0f);
    }
}
