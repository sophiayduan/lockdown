using Unity.Multiplayer.Center.Common;
using UnityEditor;
using UnityEngine;

public class State : MonoBehaviour
{
    // public GameObject inActive;
    // private Transform selection;
    // public GameObject active;
    private bool selected = false;

    void Update()
    {
        if(selected && Input.GetKeyDown(KeyCode.F)){
                gameObject.SetActive(false);

        }
        // if(!gameObject){
        //     Debug.Log("Its inactivve!");
        //     // inActive.SetActive(false);
        //     // active.SetActive(true);

        // }
        
    }
     void OnTriggerEnter(Collider other)
    {
        Outline outline = GetComponent<Outline>();
        Debug.Log("got triggered");

        if(other.tag == "aimSphere")
        {
            Debug.Log("GOT IT");
            outline.enabled = true;
            selected = true;

        }

    }
     void OnTriggerExit(Collider other)
    {
        Outline outline = GetComponent<Outline>();

        outline.enabled = false;


    }


}
