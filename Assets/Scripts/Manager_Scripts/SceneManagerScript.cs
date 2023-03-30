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
}


/*

Made by : Rey M. Oronos, Jr.
Project : Pool Shot

*/