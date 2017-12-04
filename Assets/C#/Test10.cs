using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test10 : MonoBehaviour {

    public static int guiDepth = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        GUI.depth = guiDepth;
        if (GUI.RepeatButton(new Rect(Screen.width/5,Screen.height/5,Screen.width/5,Screen.height/5),"GoBack"))
        {
            //绘制一个名为GoBack的RepeatButton
            guiDepth = 1;                                           //若持续按下按钮GoBack，guiDepth变量置为1
            Test9.guiDepth = 0;                                     //Test9.guiDepth的值置为0
        }
    }
}
