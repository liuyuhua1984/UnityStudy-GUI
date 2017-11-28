using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIBwtFront : MonoBehaviour {
    /// <summary>
    /// 矩形区域窗口
    /// </summary>
    private Rect windowRect = new Rect(20,20,120,50);
    /// <summary>
    /// 矩形窗口2
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
        //绘制第一个窗口
        windowRect = GUI.Window(0,windowRect,DoMyFirstWindow,"First");
        windowRect2 = GUI.Window(1,windowRect2,DoMySecondWindow,"Second");
    }

    void DoMyFirstWindow(int windowId)
    {
        if (GUI.Button(new Rect(10,20,100,20),"Bring to front"))
        {
            GUI.BringWindowToFront(1);//将id为1的窗口置于最上方
        }

        GUI.DragWindow(new Rect(0,0,10000,20));//绘制一个可拖动的窗口
    }

    void DoMySecondWindow(int windowId)
    {
        if (GUI.Button(new Rect(10,20,100,20),"Bring to front2"))
        {
            GUI.BringWindowToFront(0);
        }

        GUI.DragWindow(new Rect(0,0,10000,20));
    }
}
