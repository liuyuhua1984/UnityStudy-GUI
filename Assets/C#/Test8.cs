using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test8 : MonoBehaviour {
    public string lastTooltip = "";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnGUI()
    {
        //通过GUI的布局管理器绘制一个按钮Button1
        GUILayout.Button(new GUIContent("Player Game","BUtton1"));
        GUILayout.Button(new GUIContent("Quit","Button2"));
        if (Event.current.type == EventType.Repaint&& GUI.tooltip != lastTooltip)
        {
            if (lastTooltip !="")
            {
                SendMessage(lastTooltip + "OnMouseOut",SendMessageOptions.DontRequireReceiver);
            }

            if (GUI.tooltip != "")
            {
                SendMessage(GUI.tooltip+"OnMouseOver",SendMessageOptions.DontRequireReceiver);
            }
            lastTooltip = GUI.tooltip;
        }
    }

    /// <summary>
    /// 声明Button1MouseOver方法
    /// </summary>
    void ButtonOnMouseOver()
    {
        Debug.Log("Play game got focus");
    }

    void Button2OnMouseOut()
    {
        Debug.Log("Quit lost focus");
    }

}
