using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    [Header("移動速度")]
    public float Speed;
    [Header("Player")]
    public GameObject Player;
    [Header("移動音效")]
    public AudioSource WalkMusic;

    // Start is called before the first frame update
    void Start()
    {
        WalkMusic = GameObject.FindGameObjectWithTag("Walk").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        WalkMusic.Play();
        transform.Translate(Input.GetAxis("Horizontal") * Speed * Time.deltaTime,0, Input.GetAxis("Vertical") * Speed * Time.deltaTime);
        transform.Translate(Input.GetAxis("Horizontal_J") * Speed * Time.deltaTime, 0, Input.GetAxis("Vertical_J") * Speed * Time.deltaTime);
    }
}
