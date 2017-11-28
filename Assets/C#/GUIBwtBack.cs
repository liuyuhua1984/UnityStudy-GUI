using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIBwtBack : MonoBehaviour {

    //窗口的矩形区域
    private Rect windowRect = new Rect(20,20,120,50);
    /// <summary>
    /// 窗口矩形区域2
    /// </summary>
    private Rect windowRect2 = new Rect(80,20,120,50);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        windowRect = GUI.Window(0,windowRect,DoMyFirestWindow,"First");
        windowRect2 = GUI.Window(1,windowRect2,DoMySecondWindow,"Second");
    }

    void DoMyFirestWindow(int windowId)
    {
        if (GUI.Button(new Rect(10,20,100,20),"Put Back"))
        {
            GUI.BringWindowToBack(windowId);//将Id为0的窗口置于最后
        }

        GUI.DragWindow(new Rect(0,0,10000,20));
    }

    void DoMySecondWindow(int windowId)
    {
        if (GUI.Button(new Rect(10,20,100,20),"Put Back2"))
        {
            GUI.BringWindowToBack(windowId);
        }

        GUI.DragWindow(new Rect(0,0,10000,20));//绘制一个可拖动的窗口
    }
}
