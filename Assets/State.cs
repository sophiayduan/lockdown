using Unity.Multiplayer.Center.Common;
using UnityEditor;
using UnityEngine;

public class State : MonoBehaviour
{
    // public GameObject inActive;
    // private Transform selection;
    // public GameObject active;
    private bool selected = false;

    void Start()
    {
        Outline outline = GetComponent<Outline>();

    }
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
    private void OnTriggerEnter(Collider other)
    {
        Outline outline = GetComponent<Outline>();

        if(other.tag == "aimSphere"){
            Debug.Log("GOT IT");
            outline.enabled = true;
            selected = true;

        }
        

        }
    private void OnTriggerExit(Collider other)
    {
        Outline outline = GetComponent<Outline>();
        outline.enabled = false;


    }


}
