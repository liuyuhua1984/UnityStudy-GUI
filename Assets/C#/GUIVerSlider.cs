using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIVerSlider : MonoBehaviour {

    public float vSliderValue = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        //绘制一个初始值为vSliderValue的竖直滑杆
        Rect rect = new Rect(Screen.width/10,Screen.height/10,Screen.width/10,Screen.height/2);
        vSliderValue = GUI.VerticalSlider(rect, vSliderValue,10.0f,0.0f);
    }
}
