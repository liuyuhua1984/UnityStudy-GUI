using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIDgWindow : MonoBehaviour {
    public Rect windowRect = new Rect(20,20,120,50);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        windowRect = GUI.Window(0,windowRect,DoMyWindow,"My Window");
    }
    /// <summary>
    /// 创建一个手动窗口
    /// </summary>
    /// <param name="windowId"></param>
    void DoMyWindow(int windowId)
    {
        GUI.DragWindow(new Rect(0,0,10000,20));
    }
}
