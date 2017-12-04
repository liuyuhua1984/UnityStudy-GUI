using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIWindow4 : MonoBehaviour {
    public Rect windowRect0 = new Rect(20,20,120,50);
    public Rect windowRect1 = new Rect(20,100,120,50);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //设置GUI的color变量为红色，并在windowRect0区域内绘制一个窗口
        GUI.color = Color.red;
        windowRect0 = GUI.Window(0,windowRect0,DoMyWindow,"RedWindow");
        //设置为绿色
        GUI.color = Color.green;
        windowRect1 = GUI.Window(1,windowRect1,DoMyWindow,"GreenWindow");
    }


    void DoMyWindow(int windowId)
    {
        if (GUI.Button(new Rect(10,20,100,20),"Hello World"))
        {
            print("按吧!!");
        }

        //在自定义处于内绘制一个可拖动窗口
        GUI.DragWindow(new Rect(0,0,10000,10000));
    }
}
