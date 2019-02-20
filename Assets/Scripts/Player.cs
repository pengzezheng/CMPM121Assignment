using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    float speed = 3;
    float rotationSpeed = 80;
    private Animator anima;
    //GameObject particleSys;
    // GameObject particleSys2;
    public int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        anima = GetComponent<Animator>();
        /*particleSys = GameObject.Find("PickUpEffect");       
        particleSys2 = GameObject.Find("PickUpEffect2");       
        particleSys.SetActive(false);
        particleSys2.SetActive(false);*/
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        if (Input.GetKey(KeyCode.W))
        {
            anima.SetBool("walk",true);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
         else if (Input.GetKey(KeyCode.S))
        {
            anima.SetBool("Backwalk", true);
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        else
        {
            anima.SetBool("walk", false);
            anima.SetBool("Backwalk", false);
        }
        //Rotation
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -rotationSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * -rotationSpeed);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Keycard")
        {
            //particleSys.transform.position = other.gameObject.transform.position;           
            //particleSys.SetActive(true); 
            Destroy(other.gameObject);
            count++;
        }

        if (other.gameObject.name == "Keycard2")
        {
            //particleSys2.transform.position = other.gameObject.transform.position;
            //particleSys2.SetActive(true);
            Destroy(other.gameObject);
            count++;
        }

        if (other.gameObject.name == "RestartPoint")
        {
            SceneManager.LoadScene(0);
        }
    }
}
