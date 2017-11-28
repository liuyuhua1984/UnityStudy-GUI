using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUILabel : MonoBehaviour {
    /// <summary>
    /// 声明一个纹理图片
    /// </summary>
    public Texture2D textureToDisplay;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        //绘制一个文件表情
        GUI.Label(new Rect(Screen.width/10,Screen.height/10,Screen.width/5,Screen.height/10),"Hello World!");

        //绘制一个纹理图片
        GUI.Label(new Rect(Screen.width/10,Screen.height/3,textureToDisplay.width,textureToDisplay.height),textureToDisplay);
    }
}
