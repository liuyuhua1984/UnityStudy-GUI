using System.Collections;
using UnityEngine;

public class GUIFcWindow : MonoBehaviour {
    private Rect windowRect = new Rect(20,20,120,50);
    private Rect windowRect2 = new Rect(20,80,120,50);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   void OnGUI()
    {
    
        windowRect = GUI.Window(0,windowRect, DoMyFirstWindow, "First");

        windowRect2 = GUI.Window(1,windowRect2, DoMySecondWindow, "Second");
    }

    void DoMyFirstWindow(int windowId)
    {
        if (GUI.Button(new Rect(10,20,100,20),"Focus other"))
        {
            GUI.FocusWindow(1);
        }
    }

    void DoMySecondWindow(int swindowId)
    {
        if (GUI.Button(new Rect(10,20,100,20),"Focus other1"))
        {
            //把id为0的设置为焦点窗口
            GUI.FocusWindow(0);
        }
    }
}
