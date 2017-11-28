using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIPwField : MonoBehaviour {
    /// <summary>
    /// 声明一个字符串
    /// </summary>
    public string passwordToEdit = "My Password";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        //绘制一个密码框
        passwordToEdit = GUI.PasswordField(new Rect(Screen.width/10,Screen.height/10,Screen.width/2,Screen.height/10),passwordToEdit,"*"[0],25);
    }
}
