using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public string userName = "userName";
    public string pwd = "a pwd";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        //给下一步控制事件命名MyTextField
        GUI.SetNextControlName("MyTextField");
        //绘制一个单选文本编辑框,并将字符串useName的内容赋给它
        userName = GUI.TextField(new Rect(Screen.width/10,Screen.height/10,Screen.width/3,Screen.height/10),userName);

        //绘制一个单行文本编辑框,并将字符串pwd的内容赋给它
        pwd = GUI.TextField(new Rect(Screen.width/10,Screen.height/4,Screen.width/3,Screen.height/10),pwd);
        //绘制一个名字为MOVE Focus的按钮,并判定按钮是否被按下
        if (GUI.Button(new Rect(Screen.width/10,Screen.height*2/5,Screen.width/6,Screen.height/10),"Move Focus"))
        {
            GUI.FocusControl("MyTextField");
        }
    }
}
