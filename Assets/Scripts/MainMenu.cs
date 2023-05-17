using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string gameSceneName = "GameScene";
    public string creditsSceneName = "CreditsScene";

    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }


    public void ExitGame()
    {
        // Exit the application in the standalone build
        #if UNITY_STANDALONE
        Application.Quit();
        #endif

        // Stop the editor play mode in the Unity Editor
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
        #endif
    }
}