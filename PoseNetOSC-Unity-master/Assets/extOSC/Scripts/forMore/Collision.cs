using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject sphere;

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            controlScript.instance.setCounter();

            Debug.Log("Aqui tengo " + controlScript.instance.getCounter().ToString());
            
            //counter++;
            // SetCountText();
        }


    }

}
