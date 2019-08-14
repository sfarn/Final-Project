using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorEnter : MonoBehaviour
{
    private Inventory inventory;
    private Inventory2 inventory2;
    public GameObject[] items;
    public int RGet;
    public int YGet;
    //public int coget;
    public bool Rcoget;
    public bool Ycoget;
    public string sceneName;


    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Red").GetComponent<Inventory>();
        inventory2 = GameObject.FindGameObjectWithTag("Yellow").GetComponent<Inventory2>();
        RGet = 0;
        YGet = 0;
        //coget = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (RGet >= 5)
        {
            Rcoget = true;
        }
        if (YGet >= 5)
        {
            Ycoget = true;
        }

        if (Rcoget == true)
        {
            if (Ycoget == true)
            {
                Debug.Log("Go in");
                //Load scene
                SceneManager.LoadScene(sceneName);
            }
        }
      
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Red"))
        {
            for (int i = 0; i < inventory.redSlots.Length; i++) //check through the inventory slot
            {
                if (inventory.redSlots[i] != null)
                {
                    if (Inventory.Instance.GoodKey > 0) //one key
                    {
                        //RGet++;

                        if (Inventory.Instance.Gems > 1) //two gem
                        {
                           //RGet++;
                            if (Inventory.Instance.Food > 0) //one food
                            {
                               // Debug.Log("got all");//load scene
                                RGet++;
                            }
                        }
                    }

                }


            }

        }

        if (other.CompareTag("Yellow"))
        {
            Debug.Log("got all");
            for (int i = 0; i < inventory2.yellowSlots.Length; i++) //check through the inventory slot
            {
                if (inventory2.yellowSlots[i] != null)
                {
                    if (Inventory2.Instance.yGoodKey > 0)
                    {
                       if (Inventory2.Instance.yRopes > 1)  //2 ropes
                            {
                            if (Inventory2.Instance.yFood > 0)
                                {
                                    Debug.Log("got all"); //load scene
                                    YGet++;
                            }
                            }
                        }
                    }
                }
            }
        }
    }


