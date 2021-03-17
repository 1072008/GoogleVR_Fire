using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class startVR : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        this.transform.position = new Vector3(Mathf.Clamp(this.transform.position.x, -5f, 45f), Mathf.Clamp(this.transform.position.y, 10f, 18f), Mathf.Clamp(this.transform.position.z, 2f, 28f));
        
    }
}
