using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;
    public GameObject components;
    public int componentAmount;
    [SerializeField] GameObject winPanel;
    public bool hasWon = false;
    private int count = 0;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            pausePanel.SetActive(!pausePanel.activeSelf);
            if(pausePanel) Time.timeScale = 0f; 
            else Time.timeScale = 1f;
        }

        foreach(Transform child in components.transform){
            // GameObject childObject = child.gameObject;
            if(child.gameObject.activeSelf == false) count += 1;

            else break;

        }
        if(!hasWon && count >= componentAmount){
            winPanel.SetActive(true);
            Time.timeScale = 0;
            hasWon = true;

        }

        if(hasWon && Input.GetKeyDown(KeyCode.Space)){
            winPanel.SetActive(false);
            Time.timeScale = 1;
        }
    }

    
}
