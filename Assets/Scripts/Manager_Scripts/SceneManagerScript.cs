using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour {
    
    public void LoadMenuScene() {
        SceneManager.LoadScene("MenuScene");
    } //-- LoadMenuScene Function

    public void LoadLevelScene() {
        int num = PersistentManagerScript.Instance.Level_Option;
        string scene = "LevelScene_" + num.ToString();

        SceneManager.LoadScene(scene);
    } //-- LoadLevelScene Function

    public void LoadFreePlayScene() {
        int num = PersistentManagerScript.Instance.FreePlay_Option;
        string scene = "FreePlayScene_" + num.ToString();

        SceneManager.LoadScene(scene);
    } //-- LoadFreePlayScene Function

    public void QuitGame() {
        UnityEditor.EditorApplication.isPlaying = false;    // Exit from Editor
        // Application.Quit();      // Exit from Build Application
    } //-- QuitGame Function
}


/*

Made by : Rey M. Oronos, Jr.
Project : Pool Shot

*/