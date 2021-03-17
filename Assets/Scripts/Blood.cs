using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blood : MonoBehaviour
{

    
    [Header("固定時間")]
    public int static_time=60;
    [Header("UI")]
    public Slider blood;
    public GameObject ending_fail;
    public GameObject ending_finish;
    [Header("各種bool")]
    static public bool door_time=false;
    static public bool phone_time = false;
    static public bool alive = true;
    static public bool end_finish = false;

    public AudioSource Music;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("time_wait", 1, 1);
        Music = GameObject.FindGameObjectWithTag("startmusic").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(static_time<=15)
        {
            door_time = true;
            phone_time = true;
        }
        
        if(blood.value<=0)
        {
            Time.timeScale = 0;
            ending_fail.SetActive(true);
            alive = false;
            Music.Stop();
        }

        if(end_finish==true)
        {
            Time.timeScale = 0;
            ending_finish.SetActive(true);
            Music.Stop();
        }
        
    }
    public void time_wait()
    {

        //Debug.Log("run");
        blood.value -= 1;
        static_time -= 1;
        

    }
}
