using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIWindow1 : MonoBehaviour {
    public Rect windowRect = new Rect(20,20,120,50);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        //在windowRect矩形区域内绘制一个名为My Window的窗口
        windowRect = GUI.Window(0,windowRect,DoMyWindow,"My Window");
    }

    void DoMyWindow(int windowId)
    {
        if (GUI.Button(new Rect(10,20,100,20),"Hello World"))
        {
            print("Got a click");
        }
    }
}
