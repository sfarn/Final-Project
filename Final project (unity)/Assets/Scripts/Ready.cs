using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ready : MonoBehaviour
{
    public int ReadyNum;
    //public int yellowReady;

    public Text Red;
    public Text Yellow;
    public string sceneName;



    // Start is called before the first frame update
    void Start()
    {
        ReadyNum = 0;
        //yellowReady = 0;
        Red.text = "Getting Ready...";
        Yellow.text = "Getting Ready...";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            ReadyNum++;
            Red.text = "Ready";

        }
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            ReadyNum++;
            Yellow.text = "Ready";
        }

        if(ReadyNum > 1)
        {
            SceneManager.LoadScene(sceneName);

        }
    }
}
