using UnityEngine;

public class State : MonoBehaviour
{
    public GameObject inActive;
    public GameObject active;

    void Update()
    {
        if(!gameObject){
            inActive.SetActive(false);
            active.SetActive(true);

        }
    }
}
