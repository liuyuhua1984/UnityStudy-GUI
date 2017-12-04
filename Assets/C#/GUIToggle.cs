using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIToggle : MonoBehaviour {
    /// <summary>
    /// 一张纹理图
    /// </summary>
    public Texture aTexture;
    /// <summary>
    /// 一个初始值为false的bool变量toggleTxt
    /// </summary>
    private bool toggleTxt = false;
    /// <summary>
    /// 一个初始值为false的bool变量toggleImg
    /// </summary>
    private bool toggleImg = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        if (!aTexture)
        {
            Debug.LogError("图片为空");
            return;
        }

        Rect rect = new Rect(Screen.width/10,Screen.height/10,Screen.width/3,Screen.height/10);
        toggleTxt = GUI.Toggle(rect, toggleTxt, "A Toggle text");

        rect = new Rect(Screen.width/10,Screen.height/4,Screen.width/10,Screen.height/10);
        toggleImg = GUI.Toggle(rect, toggleImg, aTexture);
    }
}
