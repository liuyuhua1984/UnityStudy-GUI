using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test4 : MonoBehaviour {
    public string stringToEdit = "Modify me";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        //绘制一个单行文本编辑框，并将输入的数据赋给变量stringToEdit
        Rect rect = new Rect(Screen.width/10,Screen.height/10,Screen.width/4,Screen.height/10);
        stringToEdit = GUI.TextField(rect,stringToEdit,25);
        if (GUI.changed)
        {
            //调用changed变量，检测输入数据是否发生改变
            Debug.Log("Text field has changed");
        }
    }
}
