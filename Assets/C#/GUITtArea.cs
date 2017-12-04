using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUITtArea : MonoBehaviour {
    public string stringToEdit = "Hello World\nI.ve got 2 lines...";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        //绘制一个多行文本编辑框，并将上面声明的字符串赋给它，并设置多行文本编辑框的最大长度为200
        stringToEdit = GUI.TextArea(new Rect(Screen.width/10,Screen.height/10,Screen.width/2,Screen.height/2),stringToEdit,200);
    }
}
