using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIWindow3 : MonoBehaviour {
    public bool doWindow0 = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void DoWindow0(int windowId)
    {
        GUI.Button(new Rect(10,30,80,20),"Click Me!");
    }

    private void OnGUI()
    {
        //绘制一个开关，并将doWindow0的值赋给开关
        doWindow0 = GUI.Toggle(new Rect(10,10,100,20),doWindow0,"Window 0");
        //对doWindow0变量进行判定，判断是否绘制窗口
        if (doWindow0)
        {
            GUI.Window(0,new Rect(110,10,200,60), DoWindow0,"Basic Window");
        }
    }
}
