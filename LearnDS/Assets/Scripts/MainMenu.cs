using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    Update is called once per frame
    void Update()
    {
        
    }*/
    
    public void PlayGame(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    public void PlayStack(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    public void PlayQueue(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    public void PlayArray(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }

    public void QueueGame(int sceneID)
    {
        SceneManager.LoadScene(sceneID);
    }
    /*public void QuitGame()
    {
        Debug.Log("QUIT");
        SceneManager.LoadScene("Quit");
    }*/
}
