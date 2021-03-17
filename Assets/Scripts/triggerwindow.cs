using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class triggerwindow : MonoBehaviour
{
    [Header("彈跳視窗")]
    private Rect windowPosition;//儲存不可被拖曳的window的位置
    private Rect buttonPosition;//儲存button在window內的位置
    private Rect buttonPosition2;//儲存button2在window內的位置

    // Start is called before the first frame update
    void Start()
    {
            
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void window_run()
    {
        setWindowPosition();
        setButtonPosition();
    }
    public void setWindowPosition()//設定window的位置
    {
        float windowWidth = 300f;
        float windowHeight = 200f;
        float windowLeft = Screen.width * 0.5f - windowWidth * 0.5f;//window和Game左邊的距離，目前設定的值會讓window顯示在螢幕正中央
        float windowTop = Screen.height * 0.5f - windowHeight * 0.5f;//window和Game上面的距離，目前設定的值會讓window顯示在螢幕正中央
        windowPosition = new Rect(windowLeft, windowTop, windowWidth, windowHeight);
    }

    public void setButtonPosition()//設定windows內的button位置
    {
        float buttonWidth = 70f;//按鈕的寬度
        float buttonHeight = 40f;//按鈕的高度
        float buttonLeft = windowPosition.width * 0.5f - buttonWidth * 0.5f;//按鈕和window左邊的距離，目前的值會讓button顯示在window的正中央
        float buttonTop = windowPosition.height * 0.5f - buttonHeight * 0.5f;//按鈕和window上面的距離，目前的值會讓button顯示在window的正中央
        buttonPosition = new Rect(buttonLeft, buttonTop, buttonWidth, buttonHeight);//button將會顯示在window正中央
        buttonPosition2 = new Rect(buttonLeft, 150, 70, 40);//第二個btn
    }

    private void OnGUI() //程式會一直執行
    {
        //Debug.Log(windowPosition);
        GUI.color = Color.yellow;
        //顯示window，不可以被拖曳
        windowPosition = GUI.Window(0, windowPosition, windowEvent, "請問你要拿來幹嘛?");
    }

    private void windowEvent(int id)//處理視窗裡面要顯示的文字、按鈕、事件處理。必須要有一個為int的傳入參數
    {
        if (GUI.Button(buttonPosition, "拿來套頭"))//在window上顯示按鈕
        {
            if (id == 0)//若是id為0，代表是不可被拖曳的window
            {
                Debug.Log("拿來套頭");

                //windowPosition = new Rect(0, 0, 0, 0);
            }
        }
        if (GUI.Button(buttonPosition2, "沒幹嘛"))//在window上顯示按鈕
        {
            if (id == 0)//若是id為0，代表是不可被拖曳的window
            {
                Debug.Log("沒幹嘛");
            }
        }

    }
}
