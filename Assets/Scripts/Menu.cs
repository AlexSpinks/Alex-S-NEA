using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseHover : MonoBehaviour
{
    public GameObject tutorialMenu;
    // Start is called before the first frame update
    void Start()
    {
        tutorialMenu.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPlayButton()
    {
        tutorialMenu.SetActive(true);
    }
    public void OnQuitButton()
    {
        Application.Quit();
    }
    public void OnYesButton()
    {
        SceneManager.LoadScene(3);
    }
    public void OnNoButton()
    {
        SceneManager.LoadScene(1);
    }
}
