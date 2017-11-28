using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIBgEdView : MonoBehaviour {
    public Vector2 scrollPosition = Vector2.zero;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        Rect rect = new Rect(Screen.width/10,Screen.height/10,Screen.width/4,Screen.height/3);
        //屏幕自定义区域内创建一个滚动视图
        scrollPosition = GUI.BeginScrollView(rect, scrollPosition,new Rect(0,0,Screen.width/2,Screen.height/2));
        GUI.Button(new Rect(0,0,100,20),"Top-left");
        GUI.Button(new Rect(120,0,100,20),"Top-right");
        GUI.Button(new Rect(0,120,100,20),"Bottom-left");
        GUI.Button(new Rect(120, 120, 100, 100),"Bottom-right");
        GUI.EndScrollView();
    }
}
