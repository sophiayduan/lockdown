using UnityEngine;

public class State : MonoBehaviour
{
    public GameObject inActive;
    public GameObject active;

    void Update()
    {
        // if(!gameObject){
        //     Debug.Log("Its inactivve!");
        //     // inActive.SetActive(false);
        //     // active.SetActive(true);

        // }
    }
    void OnTriggerEnter(Collider other)
    {
    if(other.tag == "aimSphere" && Input.GetKeyDown(KeyCode.F)){
        Debug.Log("GOT IT");
        gameObject.SetActive(false);
    }

    }
}
