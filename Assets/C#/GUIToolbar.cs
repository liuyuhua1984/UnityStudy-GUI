using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIToolbar : MonoBehaviour {
    /// <summary>
    /// 一个初始值为0的整型变量toolbarInt
    /// </summary>
    public int toolbarInt = 0;
    public string[] toolbarStrings = new string[] {"Toolbar1","Toolbar2","Toolbar3" };
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        //绘制一个内容为toolbarStrings且当前焦点在第toolbarInt上的工具条
        toolbarInt = GUI.Toolbar(new Rect(Screen.width/10,Screen.height/10,Screen.width/2,Screen.height/10),toolbarInt,toolbarStrings);
    }

}
