using System.Collections;
using UnityEngine;

public class GUITxField : MonoBehaviour {

    public string stringToEdit = "Hello World";
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnGUI()
    {
        stringToEdit = GUI.TextField(new Rect(Screen.width/10,Screen.height/10,Screen.width/
            3,Screen.height /10),stringToEdit,25);
    }
}
