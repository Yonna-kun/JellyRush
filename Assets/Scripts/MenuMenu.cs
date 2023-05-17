using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMenu : MonoBehaviour
{
    public string gameSceneName = "GameScene";
    public string creditsSceneName = "HomeScene";

    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }   
	public void MainMenu()
    {
        SceneManager.LoadScene(creditsSceneName);
    }


}