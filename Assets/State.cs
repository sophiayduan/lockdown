using UnityEngine;

public class State : MonoBehaviour
{
    public static bool isCollected = false;
    public GameObject inActive;
    public GameObject active;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isCollected){
            gameObject.SetActive(false);
            inActive.SetActive(false);
            active.SetActive(true);

        }
    }
}
