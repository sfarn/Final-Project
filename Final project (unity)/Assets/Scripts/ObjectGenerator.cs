using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerator : MonoBehaviour
{
    public GameObject[] objects;



    // Start is called before the first frame update
    void Start()
    {

        int random = Random.Range(0, objects.Length);
        Instantiate(objects[random], transform.position, Quaternion.identity);



    }

    // Update is called once per frame
    void Update()
    {
        if(objects == null)  //if that there is no object in that point
        {
            Debug.Log("Gone");
        }
    }
}
