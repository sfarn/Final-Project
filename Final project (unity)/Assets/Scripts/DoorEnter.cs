using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorEnter : MonoBehaviour
{
    private Inventory inventory;
    private Inventory2 inventory2;
    public GameObject[] items;


    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Red").GetComponent<Inventory>();
        inventory2 = GameObject.FindGameObjectWithTag("Yellow").GetComponent<Inventory2>();
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
                if (inventory.redSlots[i] != null)
                {
                 if(Inventory.Instance.Gems > 0)
                    {
                        Debug.Log("Go in");
                    }else if(Inventory.Instance.BadKey > 0)
                    {
                        Debug.Log("Go in");
                    }


                }

                }
            }
        if (other.CompareTag("Yellow"))
        {
            for (int i = 0; i < inventory2.yellowSlots.Length; i++) //check through the inventory slot
            {
                if (inventory2.yellowSlots[i] != null)
                {
                    if (Inventory2.Instance.yGems > 0)
                    {
                        Debug.Log("Go in");
                    }
                    else if (Inventory2.Instance.yBadKey > 0)
                    {

                    }


                }

            }
        }
    }
    }

