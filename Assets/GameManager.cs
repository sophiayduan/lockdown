using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;
    public GameObject components;
    public int componentAmount;
    [SerializeField] GameObject winPanel;
    private int count = 0;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            pausePanel.SetActive(!pausePanel.activeSelf);
            if(pausePanel) Time.timeScale = 0f; 
            else Time.timeScale = 1f;
        }

    //     foreach(Transform child in components.transform){
    //         // GameObject childObject = child.gameObject;
    //         if(child.gameObject.activeSelf == false) count += 1;

    //         else break;

    //     }
    //     if(count >= componentAmount){
    //         winPanel.SetActive(true);
    //     }
    }
}
