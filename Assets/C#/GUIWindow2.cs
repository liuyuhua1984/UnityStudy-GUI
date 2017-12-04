using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIWindow2 : MonoBehaviour {
    public Rect windowRect0 = new Rect(20,20,120,50);
    public Rect windowRect1 = new Rect(20,100,120,50);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        //分别在windowRect0和windowRect1两个矩形区域内绘制两个窗口
        windowRect0 = GUI.Window(0,windowRect0, DoMyWindow,"My Window");
        windowRect1 = GUI.Window(1,windowRect1, DoMyWindow,"My Window");
    }

    void DoMyWindow(int windowId)
    {
        if (GUI.Button(new Rect(10,20,100,20),"Hello World"))
        {
            print("Got a click in window"+windowId);
        }

        GUI.DragWindow(new Rect(0,0,10000,10000));
    }
}
