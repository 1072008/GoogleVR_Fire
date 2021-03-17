using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonaction : MonoBehaviour
{
    public GameObject GO;
    [Header("正值")]
    public int x;
    [Header("反值")]
    public int y;
    public bool PointEnter_True, PointEnter_False;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PointEnter_True == true)
        {
            if (Input.GetButtonDown("Click_A"))
            {
                Debug.Log("ButtonA");
                Click_True();
            }
        }
        if (PointEnter_False == true)
        {
            if (Input.GetButtonDown("Click_A"))
            {
                Debug.Log("ButtonA");
                Click_False();
            }
        }
    }

    //[System.Obsolete]
    public void pointenter_True()
    {
        PointEnter_True = true;
    }
    public void Click_True()
    {
        GO.SetActive(false);
        Canvas.FindObjectOfType<Slider>().value += x;
        if(this.tag=="door"&&Blood.alive==true)
        {
            Blood.end_finish = true;
            //Debug.Log("Finish!");
        }
        if(this.tag=="window"&&Blood.alive==true)
        {
            Blood.end_finish = true;
        }
    }
    public void pointexit_True()
    {
        PointEnter_True = false;
    }

    //[System.Obsolete]
    public void pointenter_False()
    {
        PointEnter_False = true;
    }
    public void Click_False()
    {
        GO.SetActive(false);
        Canvas.FindObjectOfType<Slider>().value += y;
    }
    public void pointexit_False()
    {
        PointEnter_False = false;

    }
}
