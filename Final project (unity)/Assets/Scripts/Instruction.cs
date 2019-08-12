using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : MonoBehaviour
{
    public Canvas Instruct;



    // Start is called before the first frame update
    void Start()
    {
        Instruct.GetComponent<Canvas>().enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instruct.GetComponent<Canvas>().enabled = false;
        }

    }
    //void Close() 
    //{

    //}



}
