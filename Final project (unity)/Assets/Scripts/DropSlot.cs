using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropSlot : MonoBehaviour
{
    //put this on player?
    private Inventory inventory;
    private Inventory2 inventory2;
    public int hurt;


    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Red").GetComponent<Inventory>();
        inventory2 = GameObject.FindGameObjectWithTag("Yellow").GetComponent<Inventory2>();
        hurt = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Trap"))
        {
            Debug.Log("hurt");
            hurt++;
            if (hurt > 0)
            {
                Debug.Log("hurtmore");
                for (int i = 5; i > inventory.redSlots.Length; i--)
                {   //check the slot from down to up
                    if (inventory.isFull[i] == true) //there is an item
                    {
                        Debug.Log("fill");
                       Destroy(PickUp.Instance.itemButton); //destroy that item on the latest slot
                        //inventory.isFull[i] = false;  //that slot becomes empty again
                        //PlayerMove.Instance.hurt = 0;
                    }
                }


            }

        }
    }
}