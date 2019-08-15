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
           
            for (int i = inventory.redSlots.Length - 1; i >= 0; i--)
            {   //check the slot from down to up
                if (inventory.redItems[i] != null)
                {
                    string itemName = inventory.redItems[i].name;    
                    Destroy(inventory.redItems[i]);

                    
                    inventory.isFull[i] = false;


                    // find empty point
                    // instantiate correct object
                    foreach(ObjectGenerator og in PointManager.Instance.Point)
                    {
                        if (og.instantiateditem == null)
                        {
                            GameObject objectToCreate = null;
                            foreach(GameObject g in og.objects)
                            {
                                if (g.name+"(Clone)" == itemName)
                                {
                                    objectToCreate = g;
                                }
                            }

                            if (objectToCreate == null)
                            {
                                Debug.LogError("game object match not found");
                            }
                            og.instantiateditem = Instantiate(objectToCreate, og.transform.position, Quaternion.identity);
                            //objectToCreate = og.instantiateditem;
                            break;
                        }
                    }

                    break;
                }
                //if (inventory.isFull[i] == true) //there is an item
                //{
                //    Debug.Log("fill");
                //   Destroy(PickUp.Instance.itemButton); //destroy that item on the latest slot
                //    inventory.isFull[i] = false;  //that slot becomes empty again
                //    //PlayerMove.Instance.hurt = 0;
                //}
            }
            for (int i = inventory2.yellowSlots.Length - 1; i >= 0; i--)
            {   //check the slot from down to up
                if (inventory2.yellowItems[i] != null)
                {
                    string itemName = inventory2.yellowItems[i].name;
                    Destroy(inventory2.yellowItems[i]);


                    inventory2.isFull[i] = false;


                    // find empty point
                    // instantiate correct object
                    foreach (ObjectGenerator og in PointManager.Instance.Point)
                    {
                        if (og.instantiateditem == null)
                        {
                            GameObject objectToCreate = null;
                            foreach (GameObject g in og.objects)
                            {
                                if (g.name + "(Clone)" == itemName)
                                {
                                    objectToCreate = g;
                                }
                            }

                            if (objectToCreate == null)
                            {
                                Debug.LogError("game object match not found");
                            }
                            og.instantiateditem = Instantiate(objectToCreate, og.transform.position, Quaternion.identity);
                            //objectToCreate = og.instantiateditem;
                            break;
                        }
                    }

                    break;
                }
           
            }


        }

        }
    }
