using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Collider))]

public class objectstrigger : MonoBehaviour
{
    [Header("血量條")]
    public Slider bloodslider;


    public GameObject trigger_object;
    public GameObject choose_object;
    [Header("方位")]
    public int p_z;
    public int p_y;
    public int p_x;
    public int t_y;
    public bool PointEnter;
    [Header("窗戶用手機物件")]
    public GameObject cellphone;

    private bool window_open = false;
    [Header("點擊音效")]
    public AudioSource ClickMusic;
    // Start is called before the first frame update
    void Start()
    {
        ClickMusic = GameObject.FindGameObjectWithTag("Click").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //ButtonA = Input.GetAxis("Click_A");
        if (PointEnter == true)
        {
            if (Input.GetButtonDown("Click_A"))
            {
                Debug.Log("ButtonA");
                pointclick();
            }
        }
    }
    public void pointenter()
    {
        PointEnter = true;
    }

    [System.Obsolete]
    public void pointclick()
    {
        ClickMusic.Play();
        if (this.tag=="door")
        {
            if(Blood.door_time==true)
            {
                Vector3 window_position = trigger_object.transform.position;
                window_position.z += p_z;
                window_position.y += p_y;
                window_position.x += p_x;
                Instantiate(choose_object, window_position, Quaternion.Euler(0, t_y, 0));
            }
            
        }
        else if(this.tag=="phone")
        {
            if(Blood.phone_time==true)
            {
                Vector3 window_position = trigger_object.transform.position;
                window_position.z += p_z;
                window_position.y += p_y;
                window_position.x += p_x;
                Instantiate(choose_object, window_position, Quaternion.Euler(0, t_y, 0));
                window_open = true;
            }
            
        }
        else if(this.tag=="window")
        {
            this.window_open=GameObject.Find("Choose_phone").GetComponent<objectstrigger>().window_open;
            if(window_open==true)
            {

                Vector3 window_position = trigger_object.transform.position;
                window_position.z += p_z;
                window_position.y += p_y;
                window_position.x += p_x;
                Instantiate(choose_object, window_position, Quaternion.Euler(0, t_y, 0));
            }
        }
        else
        {
            Vector3 window_position = trigger_object.transform.position;
            window_position.z += p_z;
            window_position.y += p_y;
            window_position.x += p_x;
            Instantiate(choose_object, window_position, Quaternion.Euler(0, t_y, 0));
        }

        this.GetComponent<Collider>().enabled = false;
        
    }
    public void pointexit()
    {
        PointEnter = false;
    }
    
}

/*
public class objectstrigger : MonoBehaviour
{
    [Header("血量條")]
    public Slider bloodslider;
    [Header("血量變數")]
    public int x;
    [Header("測試文字")]
    public Text triggertext;
    private Rect windowPosition;//儲存不可被拖曳的window的位置
    private Rect buttonPosition;//儲存button在window內的位置
    private Rect buttonPosition2;//儲存button2在window內的位置

    public enum SelectDevice
    {
        PCUI
    }
    public SelectDevice Select_Device;
    // Start is called before the first frame update
    void Start()
    {
        //windowPosition = new Rect(100f, 100f, 100f, 100f);
    }

    private void setWindowPosition()//設定window的位置
    {
        float windowWidth = 300f;
        float windowHeight = 200f;
        float windowLeft = Screen.width * 0.5f - windowWidth * 0.5f;//window和Game左邊的距離，目前設定的值會讓window顯示在螢幕正中央
        float windowTop = Screen.height * 0.5f - windowHeight * 0.5f;//window和Game上面的距離，目前設定的值會讓window顯示在螢幕正中央
        windowPosition = new Rect(windowLeft, windowTop, windowWidth, windowHeight);
    }

    private void setButtonPosition()//設定windows內的button位置
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
        Debug.Log(windowPosition);
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


    // Update is called once per frame
    void Update()
    {
        switch (Select_Device)
        {
            //case SelectDevice.PCUI:

        }
    }
    public void pointenter()
    {
        triggertext.text = "我是互動物件，點我！";

    }
    public void pointclick()
    {
        triggertext.text = "點到了！血量扣！" + x;
        //bloodslider.value -= x;
        setWindowPosition();
        setButtonPosition();
    }
    public void pointexit()
    {
        triggertext.text = "";
        //windowPosition = new Rect(0, 0, 0, 0);
    }
}*/
