using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIHorSlider : MonoBehaviour {
    public float hSliderValue = 0.0F;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        //绘制一个初始值为hSliderValue的水平滚动条
        hSliderValue = GUI.HorizontalScrollbar(new Rect(Screen.width/10,Screen.height/10,Screen.width/3,Screen.height/10),hSliderValue,2,0.0f,0.0f);
    }
}
