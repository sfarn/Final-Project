using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    private Inventory inventory2;
    //add inventory2 for player yellow
    public GameObject itemButton;



    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Red").GetComponent<Inventory>();
        inventory2 = GameObject.FindGameObjectWithTag("Yellow").GetComponent<Inventory>();
        //add inventory2 for player yellow
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Red"))
        {
            for (int i = 0; i < inventory.redSlots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    //add items
                    Debug.Log("open");
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.redSlots[i].transform, false);
                    Destroy(gameObject);
                    Debug.Log("onefull");
                    break;
                }
            }
        }
        if (other.CompareTag("Yellow"))
        {
            for (int y = 0; y < inventory2.yellowSlots.Length; y++)
            {
                if (inventory2.isFull[y] == false)
                {
                    //add items
                    Debug.Log("open");
                    inventory2.isFull[y] = true;
                    Instantiate(itemButton, inventory2.yellowSlots[y].transform, false);
                    Destroy(gameObject);
                    Debug.Log("onefull");
                    break;
                }
            }
        }
    }
}