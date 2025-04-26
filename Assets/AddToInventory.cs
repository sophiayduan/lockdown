
using UnityEngine;

public class AddToInventory : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "component" && Input.GetKeyDown(KeyCode.F)){
            Debug.Log("GOT IT");
            other.gameObject.SetActive(false);
        }


    }
}
