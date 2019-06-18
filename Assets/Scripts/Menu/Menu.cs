using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject menuPanel; 
        //,optionsPanel;
    public void LoadScene(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    public void ExitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
    /*public void OptionsToggle(bool toggle)
    {
        if (toggle)
        {
            menuPanel.SetActive(false);
            optionsPanel.SetActive(true);
        }
        else
        {
            menuPanel.SetActive(true);
            optionsPanel.SetActive(false);
        }
    }
    */
}