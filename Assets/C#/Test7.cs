using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test7 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        //在自定义区域绘制一个Box，Box中的内容为Box，且提示信息为this box has a tooltip
        Rect rect = new Rect(Screen.width/20,Screen.height/10,Screen.width *3 /5,Screen.height * 3 /5);
        GUI.Box(rect,new GUIContent("this box has a tooltip"));
        //在自定义区域绘制一个名为No tooltip here的按钮
         rect = new Rect(Screen.width/10,Screen.height/3,Screen.width/2,Screen.height/10);
        GUI.Button(rect,"No tooltip here");
        //在自定义区域绘制一个内容为I have a tooltip的按钮，且提示信息为The button overrides the box
        rect = new Rect(Screen.width/10,Screen.height/2,Screen.width/2,Screen.height/10);
        GUI.Button(rect,new GUIContent("I have a tooltip,The button overrides the box"));
        GUI.Label(new Rect(Screen.width/10,Screen.height/5,Screen.width*2/5,Screen.height/10),GUI.tooltip);
    }
}
