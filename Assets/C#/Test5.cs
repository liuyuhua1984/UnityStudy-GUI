using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test5 : MonoBehaviour {
    public bool allOptions = true;
    public bool extended1 = true;
    public bool extended2 = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        //在自定义区域内绘制一个名为Edit All Options的开关，其初始状态为allOptions
        allOptions = GUI.Toggle(new Rect(0,0,Screen.width/5,Screen.height/10),allOptions,"Edit All Options");
        GUI.enabled = allOptions;
        extended1 = GUI.Toggle(new Rect(Screen.width/10,Screen.height/10,Screen.width/5,Screen.height/10),extended1,"Extended Option1");
        extended2 = GUI.Toggle(new Rect(Screen.width/10,Screen.height/5,Screen.width/5,Screen.height/10),extended2,"Extended Option2");
        GUI.enabled = true;//将enabled组件的值设置为true
        if (GUI.Button(new Rect(0,Screen.height *3 /10,Screen.width/3,Screen.height/10),"ok"))
        {
            print("user clicked ok");
        }

    }
}
