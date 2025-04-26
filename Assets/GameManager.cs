using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject pausePanel;

    // public MenuManager menuManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            pausePanel.SetActive(!pausePanel.activeSelf);
            if(pausePanel) Time.timeScale = 0f; 
            else Time.timeScale = 1f;
        }
    }
}
