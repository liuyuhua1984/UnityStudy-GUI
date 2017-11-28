using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIButton : MonoBehaviour {

    public Texture btnTexture;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        if (!btnTexture)
        {
            Debug.LogError("Please assign a texture on the inspector");
            return;
        }

        //创建一个纹理按钮
        if (GUI.Button(new Rect(Screen.width/10,Screen.height/10,Screen.width/10,Screen.width/10),btnTexture))
        {
            Debug.Log("Clicked the button with an image");
        }

        //创建一个文本按钮
        if (GUI.Button(new Rect(Screen.width/10,Screen.height/3,Screen.width/5,Screen.height/10),"Click"))
        {
            Debug.Log("Clicked the button with text");
        }
    }
}
