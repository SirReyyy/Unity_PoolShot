using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UI_FreePlay : MonoBehaviour {

    public SceneManagerScript _sceneManagerScript;

    public VisualElement veGameplay, vePause;
    public Button btnSettings, btnContinueP, btnRestartP, btnHomeP;
    public Label lblGameMode;


    private int fp_Option = PersistentManagerScript.Instance.FreePlay_Option;

    void OnEnable() {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        // Gameplay Container
        veGameplay = root.Q<VisualElement>("VE_Gameplay");
        lblGameMode = root.Q<Label>("Lbl_GameMode");
        btnSettings = root.Q<Button>("Btn_Settings");

        // Pause Container
        vePause = root.Q<VisualElement>("VE_Pause");
        btnContinueP = root.Q<Button>("Btn_ContinueP");
        btnRestartP = root.Q<Button>("Btn_RestartP");
        btnHomeP = root.Q<Button>("Btn_HomeP");

        // Initial VE States
        veGameplay.style.display = DisplayStyle.Flex;
        vePause.style.display = DisplayStyle.None;

        // Button Functions
        btnSettings.clicked += () => BFuncChangeVE(1);

        btnContinueP.clicked += () => BFuncChangeVE(0);
        btnRestartP.clicked += () => BFuncChangeVE(2);
        btnHomeP.clicked += () => BFuncChangeVE(3);

        lblGameMode.text = fp_Option.ToString() + "-Ball Mode";

    } // -- OnEnable Function

    void BFuncChangeVE(int num) {
        switch(num) {
            case 0:     // Gameplay VE
                veGameplay.style.display = DisplayStyle.Flex;
                vePause.style.display = DisplayStyle.None;
                break;
            case 1:     // Pause VE
                veGameplay.style.display = DisplayStyle.None;
                vePause.style.display = DisplayStyle.Flex;
                break;
            case 2:     // Restart Level VE
                PersistentManagerScript.Instance.FreePlay_Option = fp_Option;
                _sceneManagerScript.LoadFreePlayScene();
                break;
            case 3:
                PersistentManagerScript.Instance.FreePlay_Option = 0;
                _sceneManagerScript.LoadMenuScene(); 
                break;
            default:
                break;
        }
    } //-- Button Function Change VE
}


/*

Made by : Rey M. Oronos, Jr.
Project : Pool Shot

*/