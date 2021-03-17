using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    //public AudioSource Music;
    public float ButtonA;
    public bool PointEnter_Start, PointEnter_Exit;
    // Start is called before the first frame update
    void Start()
    {
        //Music = GameObject.FindGameObjectWithTag("startmusic").GetComponent<AudioSource>();
        //DontDestroyOnLoad(Music);
    }

    // Update is called once per frame
    void Update()
    {
        ButtonA = Input.GetAxis("Click_A");
        //StartGame_J();
        
        if (PointEnter_Start == true)
        {
            if (Input.GetButtonDown("Click_A"))
            {
                Debug.Log("ButtonA");
                StartGame();
            }
        }
        if (PointEnter_Exit == true)
        {
            if (Input.GetButtonDown("Click_A"))
            {
                Debug.Log("ButtonA");
                ExitGame();
            }
        }
    }

    public void pointenter_Start()
    {
        PointEnter_Start = true;
    }
    public void StartGame()
    {
        Application.LoadLevel(1);
        //Music.Play();
    }
    public void pointexit_Start()
    {
        PointEnter_Start = false;
    }

    public void pointenter_Exit()
    {
        PointEnter_Exit = true;
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void pointexit_Exit()
    {
        PointEnter_Exit = false;
    }



    /*public void ExitGame_J()
    {
        if (ButtonA == 1)
        {
            ExitGame();
        }
    }

    public void StartGame_J()
    {
        if (ButtonA == 1)
        {
            StartGame();
        }
    }*/
}
