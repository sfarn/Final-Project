using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public static Trap Instance;
    [SerializeField] Transform Respawn;
    [SerializeField] Transform Respawn2;
    public int hurt;


    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        hurt = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.CompareTag("Red"))
        {
            hurt++;
            col.transform.position = Respawn.position;
           //hurt = 0;

        }
        if (col.transform.CompareTag("Yellow"))
        {
            col.transform.position = Respawn2.position;
        }
    }

}
