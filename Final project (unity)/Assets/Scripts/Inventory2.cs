using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory2 : MonoBehaviour
{
    public bool[] isFull;
    //public GameObject[] redSlots;
    public GameObject[] yellowSlots;
    public int index;
    public static Inventory2 Instance;
    public GameObject[] yellowItems;

    public int yGems;
    public int yBadKey;
    public int yGoodKey;
    public int yFeathers;
    public int yFood;
    public int yGums;
    public int yRopes;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        index = 0;
        //items
        yGems = 0;
        yBadKey = 0;
        yGoodKey = 0;
        yFeathers = 0;
        yFood = 0;
        yGums = 0;
        yRopes = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
