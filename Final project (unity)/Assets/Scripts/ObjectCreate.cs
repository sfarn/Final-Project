using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreate : MonoBehaviour
{
    public List<GameObject> points;
    public List<GameObject> objects;
    public GameObject currentItem;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 14; i > 0; i--)
        {
            int random = Random.Range(0, objects.Count); 
            GameObject point = GameObject.Find("Point"+i);
            Debug.Log("Point"+i);
            ObjectGenerator og = point.GetComponent<ObjectGenerator>();
            currentItem=Instantiate(objects[random], points[i-1].transform.position, Quaternion.identity);
            og.instantiateditem = currentItem;
            objects.RemoveAt(random);
        }
    }
}
