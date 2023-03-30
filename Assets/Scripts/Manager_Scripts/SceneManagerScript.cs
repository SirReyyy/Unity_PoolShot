using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour {
    
    public void LoadMenuScene() {
        SceneManager.LoadScene("MenuScene");
    } //-- LoadMenuScene Function

    public void LoadLevelScene() {
        SceneManager.LoadScene("LevelScene");
    } //-- LoadLevelScene Function

    public void LoadFreePlayScene() {
        SceneManager.LoadScene("FreePlayScene");
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