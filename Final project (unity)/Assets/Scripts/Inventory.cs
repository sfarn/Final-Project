using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public bool[] isFull;
    public GameObject[] redSlots;
    public GameObject[] yellowSlots;
    public GameObject[] redItems;
    //public GameObject[] yellowItems;
    public int index;
    public static Inventory Instance;

    public int Gems;
    public int BadKey;
    public int GoodKey;
    public int Feathers;
    public int Food;
    public int Gums;
    public int Ropes;
 

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        index = 0;
        //items
        Gems = 0;
        BadKey = 0;
        GoodKey = 0;
        Feathers = 0;
        Food = 0;
        Gums = 0;
        Ropes = 0;
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
