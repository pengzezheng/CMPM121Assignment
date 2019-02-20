using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalDoor : MonoBehaviour
{
    private Animator finalDoor;
    int counter;
    void Start()
    {
        finalDoor = GetComponent<Animator>();
        finalDoor.SetBool("OpenFinal", false);
    }

    void Update()
    {
        counter = GameObject.FindWithTag("Player").GetComponent<Player>().count;
        if (counter > 1)
        {
            finalDoor.SetBool("OpenFinal", true);
        }
    }
}
