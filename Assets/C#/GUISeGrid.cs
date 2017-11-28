﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUISeGrid : MonoBehaviour {
    public int selGridInt = 0;
    public string[] selStrings = new string[] {"Grid 1", "Grid 2", "Grid 3", "Grid 4" };
	// Use this for initialization
	void Start () {
        //绘制一个内容为selString且当前焦点在第selGridInt 上的网格按钮控件

        selGridInt = GUI.SelectionGrid(new Rect(Screen.width/10,Screen.height/10,Screen.width/2,Screen.height/3),selGridInt,selStrings,2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
