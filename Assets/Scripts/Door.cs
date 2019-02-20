using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private Animator door;
    int counter;
    void Start()
    {
        door = GetComponent<Animator>();        
        door.SetBool("Open", false);
    }

    void Update()
    {
        counter = GameObject.FindWithTag("Player").GetComponent<Player>().count;
        if (counter > 0)
        {
            door.SetBool("Open", true);
        }
    }
}
