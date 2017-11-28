using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUISName : MonoBehaviour {
    public string login = "username";
    public string login2 = "no action here";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        //设置下一步控件事件的名字为user
        GUI.SetNextControlName("user");
        //绘制一个单行文本编辑框
        login = GUI.TextField(new Rect(Screen.width/10,Screen.height/10,Screen.width/3,Screen.height/10),login);

        login2 = GUI.TextField(new Rect(Screen.width/10,Screen.height/3,Screen.width/3,Screen.height/10),login2);
        //判断当前事件是否为键盘事件return,判断当前事件的名字是否为user
        if (Event.current.Equals(Event.KeyboardEvent("return"))&& GUI.GetNameOfFocusedControl() == "user")
        {
            Debug.Log("Login");
        }

        //绘制一个按钮
        if (GUI.Button(new Rect(Screen.width/2,Screen.height/10,Screen.width/5,Screen.height/10),"Login"))
        {
            Debug.Log("Login");
        }
    }
}
