using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    private Inventory2 inventory2;
    //add inventory2 for player yellow
    public GameObject itemButton;
    public static PickUp Instance;
    //public int Gems;


    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Red").GetComponent<Inventory>();
        inventory2 = GameObject.FindGameObjectWithTag("Yellow").GetComponent<Inventory2>();
        //add inventory2 for player yellow
        Instance = this;

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Red"))
        {
            for (int i = 0; i < inventory.redSlots.Length; i++)  //up to down
            {
                if (inventory.isFull[i] == false)
                {
                    //add items
                    //Debug.Log("open");
                    inventory.isFull[i] = true;
                    inventory.redItems[i] = Instantiate(itemButton, inventory.redSlots[i].transform, false);
                   
                    if (itemButton.name == "Gems")
                    {
                        Debug.Log("Gems");
                        Inventory.Instance.Gems++;
                    }
                    if (itemButton.name == "BKeys")
                    {
                        Debug.Log("BK");
                        Inventory.Instance.BadKey++;
                    }
                    if (itemButton.name == "Feathers")
                    {
                        Debug.Log("F");
                        Inventory.Instance.Feathers++;
                    }
                    if (itemButton.name == "Food")
                    {
                        Debug.Log("Food");
                        Inventory.Instance.Food++;
                    }
                    if (itemButton.name == "Gums")
                    {
                        Debug.Log("gum");
                        Inventory.Instance.Gums++;
                    }
                    if (itemButton.name == "Ropes")
                    {
                        Debug.Log("rope");
                        Inventory.Instance.Ropes++;
                    }
                    if (itemButton.name == "GdKeys")
                    {
                        Debug.Log("gd key");
                        Inventory.Instance.GoodKey++;
                    }

                    Destroy(gameObject);
                    //Debug.Log("onefull");
                    Inventory.Instance.index++;
                    break;
                }
            }

            //if (PlayerMove.Instance.hurt > 0) //its not detecting
            //{
            //    Debug.Log("hurt");
            //    for (int i = 5; i > inventory.redSlots.Length; i--)
            //    {   //check the slot from down to up
            //        if (inventory.isFull[i] == true) //there is an item
            //        {
            //            Debug.Log("fill");
            //            Destroy(itemButton); //destroy that item on the latest slot
            //            inventory.isFull[i] = false;  //that slot becomes empty again
            //            //PlayerMove.Instance.hurt = 0;
            //        }
            //    }
            //}
        }
            if (other.CompareTag("Yellow"))
            {
                for (int y = 0; y < inventory2.yellowSlots.Length; y++)
                {
                    if (inventory2.isFull[y] == false)
                    {
                        //add items
                        //Debug.Log("open");
                        inventory2.isFull[y] = true;
                        inventory2.yellowItems[y] = Instantiate(itemButton, inventory2.yellowSlots[y].transform, false);

                        if (itemButton.name == "Gems")
                        {
                            Debug.Log("Gems");
                            Inventory2.Instance.yGems++;
                        }
                        if (itemButton.name == "BKeys")
                        {
                            Debug.Log("BK");
                            Inventory2.Instance.yBadKey++;
                        }
                        if (itemButton.name == "Feathers")
                        {
                            Debug.Log("F");
                            Inventory2.Instance.yFeathers++;
                        }
                        if (itemButton.name == "Food")
                        {
                            Debug.Log("Food");
                            Inventory2.Instance.yFood++;
                        }
                        if (itemButton.name == "Gums")
                        {
                            Debug.Log("gum");
                            Inventory2.Instance.yGums++;
                        }
                        if (itemButton.name == "Ropes")
                        {
                            Debug.Log("rope");
                            Inventory2.Instance.yRopes++;
                        }
                        if (itemButton.name == "GdKeys")
                        {
                            Debug.Log("gd key");
                            Inventory2.Instance.yGoodKey++;
                        }

                        Destroy(gameObject);
                    //Instantiate(gameObject);
                        //Debug.Log("onefull");
                        break;
                    }
                }
            }
       
    }
}