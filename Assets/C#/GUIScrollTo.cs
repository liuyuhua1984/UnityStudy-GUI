using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIScrollTo : MonoBehaviour {
    /// <summary>
    /// 初始值(0,0)
    /// </summary>
    public Vector2 scrollPos = Vector2.zero;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        //在屏幕指定区域内创建一个自定义滚动区域
        scrollPos = GUI.BeginScrollView(new Rect(Screen.width/10,Screen.height/10,Screen.width/5,Screen.height/4),scrollPos,new Rect(0,0,Screen.width/2,Screen.height/10));
        if (GUI.Button(new Rect(0,0,Screen.width/5,Screen.height/10),"Go Right"))
        {
            //前前焦点即可跳到指定的区域
            GUI.ScrollTo(new Rect(Screen.width/4,0,Screen.width/4,Screen.height/10));
        }
        if (GUI.Button(new Rect(Screen.width/4,0,Screen.width/5,Screen.height/10),"GO Left"))
        {
            GUI.ScrollTo(new Rect(0,0,Screen.width/5,Screen.height/10));
        }
        //撤销滚动视图
        GUI.EndScrollView();
    }
}
