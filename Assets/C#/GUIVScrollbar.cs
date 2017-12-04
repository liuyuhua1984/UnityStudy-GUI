using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIVScrollbarGUIVScrollbar : MonoBehaviour {
    /// <summary>
    ///  声明一个浮点型变量hSbarValue
    /// </summary>
    public float vSbarValue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        //绘制一个初始值为hSbarValue的竖直滚动条
        Rect rect = new Rect(Screen.width/10,Screen.height/10,Screen.width/10,Screen.height/3);
        vSbarValue = GUI.VerticalScrollbar(rect,vSbarValue,1.0f,10.0f,0.0f);
    }
}
