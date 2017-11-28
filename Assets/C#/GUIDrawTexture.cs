using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIDrawTextureGUIDrawTexture : MonoBehaviour {
    public Texture aTexture;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        GUI.DrawTexture(new Rect(Screen.width/10,Screen.height/10,Screen.width/5,Screen .height/5),aTexture,ScaleMode.ScaleToFit,true,0.0f);
    }
}
