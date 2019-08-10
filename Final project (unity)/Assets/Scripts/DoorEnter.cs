using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEnter : MonoBehaviour
{
    private Inventory inventory;
    public GameObject[] items;


    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Red").GetComponent<Inventory>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Red"))
        {
            for (int i = 0; i < inventory.redSlots.Length; i++) //check through the inventory slot
            {
                if(inventory.redSlots[i] != null)
                {
                    Debug.Log("Yes");  //have stuff
                    //check the inventory there is this item
                }
                //if(GameObject.Find("Gems 1") == true)
                //{
                //    Debug.Log("Go in");
                //}
                //if(inventory.redSlots[i] == GameObject.Find("Gems 1")){
                //    Debug.Log("Go in");
                //}
                //if (inventory.redSlots[i] == inventory.redSlots[0])
                //{
                //    Debug.Log("Go in");
                //}

            }
        }
    }
}
