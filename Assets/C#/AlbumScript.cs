using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlbumScript : MonoBehaviour {

    /// <summary>
    /// 背景纹理图片
    /// </summary>
    public Texture backgroundTex;
    /// <summary>
    /// 相册标题纹理图片
    /// </summary>
    public Texture albumTex;
    /// <summary>
    /// 示例图片1
    /// </summary>
    public Texture texture1;
    /// <summary>
    /// 示例图片2
    /// </summary>
    public Texture texture2;
    /// <summary>
    /// 示例图片3
    /// </summary>
    public Texture texture3;
    /// <summary>
    /// 示例图片4
    /// </summary>
    public Texture texture4;
    /// <summary>
    /// 示例图片5
    /// </summary>
    public Texture texture5;
    /// <summary>
    /// 场景图片数组
    /// </summary>
    public Texture[] scene;
    /// <summary>
    /// 左箭头
    /// </summary>
    public Texture leftTexture;
    /// <summary>
    /// 右箭头
    /// </summary>
    public Texture rightTexture;
    /// <summary>
    /// 确定按钮
    /// </summary>
    public Texture okTexture;
    /// <summary>
    /// 返回图片
    /// </summary>
    public Texture returnTexture;

    public GUIStyle myStyle;
    private int i = 1;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //如果是android平台
		if (Application.platform == RuntimePlatform.Android){
           if (Input.GetKeyUp(KeyCode.Home))
            {
                //HOME
                Application.Quit();
            }
           if (Input.GetKeyUp(KeyCode.Escape))//返回键
            {
                Application.Quit();
            }

        }
	}

    private void OnGUI()
    {
        float ratioScaleTempH = Screen.height / 960.0f;//屏幕自适应的纵向绽放比变量
        float ratioScaleTempW = Screen.width / 540.0f;//屏幕自适应的横向绽放比变量

        Rect windowRect = new Rect(20 * ratioScaleTempW, 250 * ratioScaleTempH, 500 * ratioScaleTempW, 550 * ratioScaleTempH);
        //绘制图片背景
        GUI.DrawTexture(new Rect(0,0,540*ratioScaleTempW,960*ratioScaleTempW),backgroundTex,ScaleMode.ScaleToFit,true,540.0f/960.0f);
        //绘制相册标题纹理图片，并实现屏幕自适应
        GUI.DrawTexture(new Rect(170*ratioScaleTempW,20*ratioScaleTempH,200*ratioScaleTempW,100*ratioScaleTempH),albumTex,ScaleMode.ScaleToFit,true,200.0f/100.0f);

        //绘制左箭头按钮
        if (GUI.Button(new Rect(20*ratioScaleTempW,145*ratioScaleTempH,50*ratioScaleTempW,50*ratioScaleTempH),
            leftTexture,myStyle))
        {
            i--;
            if (i<=0)
            {
                i = 4;
            }
        }

        //绘制图片1纹理图片
        if (GUI.Button(new Rect(70*ratioScaleTempW,130*ratioScaleTempH,80*ratioScaleTempW,80*ratioScaleTempH),texture1,myStyle))
        {
            i = 0;
        }
        //绘制图片2纹理图片
        if (GUI.Button(new Rect(150 * ratioScaleTempW, 130 * ratioScaleTempH, 80 * ratioScaleTempW, 80 * ratioScaleTempH), texture2, myStyle))
        {
            i = 1;
        }
        //绘制图片3纹理图片
        if (GUI.Button(new Rect(230 * ratioScaleTempW, 130 * ratioScaleTempH, 80 * ratioScaleTempW, 80 * ratioScaleTempH), texture3, myStyle))
        {
            i = 2;
        }
        //绘制图片4纹理图片
        if (GUI.Button(new Rect(310 * ratioScaleTempW, 130 * ratioScaleTempH, 80 * ratioScaleTempW, 80 * ratioScaleTempH), texture4, myStyle))
        {
            i = 3;
        }
        //绘制图片5纹理图片
        if (GUI.Button(new Rect(390 * ratioScaleTempW, 130 * ratioScaleTempH, 80 * ratioScaleTempW, 80 * ratioScaleTempH), texture5, myStyle))
        {
            i = 4;
        }
        //绘制右箭头
        if (GUI.Button(new Rect(470 * ratioScaleTempW, 145 * ratioScaleTempH, 50 * ratioScaleTempW, 50 * ratioScaleTempH), rightTexture, myStyle))
        {
            i++;
            if (i >4)
            {
                i = 0;
            }
        }

        windowRect = GUI.Window(0,windowRect,DoMyWindow,"");

        //显示确认键
        if (GUI.Button(new Rect(70*ratioScaleTempW,830*ratioScaleTempH,100*ratioScaleTempW,50*ratioScaleTempH),okTexture,myStyle))
        {
            Debug.Log("显示风景图片");
        }
        //绘制示例返回按钮
        if (GUI.Button(new Rect(370*ratioScaleTempW,830*ratioScaleTempH,100*ratioScaleTempW,50*ratioScaleTempH),returnTexture,myStyle))
        {
            Application.Quit();
        }
    }

    void DoMyWindow(int windowID)
    {
        float ratioScaleTempH = Screen.height / 960.0f;
        float ratioScaleTempW = Screen.width / 540.0f;
        //在绘制的窗口内,自定义一个区域并绘制一个与示例图片数组索引项对应的示例图片
        GUI.DrawTexture(new Rect(10 * ratioScaleTempW, 30 * ratioScaleTempH, 480 * ratioScaleTempW, 480 * ratioScaleTempH), scene[i],ScaleMode.ScaleToFit,true,500.0f /500.0f);
    }

}
