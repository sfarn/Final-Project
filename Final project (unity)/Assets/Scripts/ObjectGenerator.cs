using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerator : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject instantiateditem;




    // Start is called before the first frame update
    void Start()
    {

        int random = Random.Range(0, objects.Length);
        instantiateditem = Instantiate(objects[random], transform.position, Quaternion.identity);
        //objects[random] = instantiateditem;


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q)) //works, generate another set of random items at all point but overlap if original is still here
        { //how to generate one point at a time
            int random = Random.Range(0, objects.Length);
            Instantiate(objects[random], transform.position, Quaternion.identity);
        }

        //if (instantiateditem == null)  //if that there is no object in that point
        //{
        //    Debug.Log("Gone");
        //    int random = Random.Range(0, objects.Length);
        //    Instantiate(objects[random], transform.position, Quaternion.identity);
        //}
    }
}
