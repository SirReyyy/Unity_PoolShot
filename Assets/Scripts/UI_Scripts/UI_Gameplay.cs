using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UI_Gameplay : MonoBehaviour {
    public VisualElement veGameplay, vePause, veNextLevel;
    public Button btnSettings, btnContinueP, btnRestartP, btnHomeP;
    public Button btnContinueNL, btnRestartNL, btnHomeNL;
    public Label lblLevel, lblTask1, lblTask2, lblTask3;


    private int lvl_Option = PersistentManagerScript.Instance.Level_Option;

    void OnEnable() {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        // Gameplay Container
        veGameplay = root.Q<VisualElement>("VE_Gameplay");
        lblLevel = root.Q<Label>("Lbl_LevelTasks");
        lblTask1 = root.Q<Label>("Lbl_Task_1");
        lblTask2 = root.Q<Label>("Lbl_Task_2");
        lblTask3 = root.Q<Label>("Lbl_Task_3");
        btnSettings = root.Q<Button>("Btn_Settings");

        // Pause Container
        vePause = root.Q<VisualElement>("VE_Pause");
        btnContinueP = root.Q<Button>("Btn_ContinueP");
        btnRestartP = root.Q<Button>("Btn_RestartP");
        btnHomeP = root.Q<Button>("Btn_HomeP");

        // Next Level Container
        veNextLevel = root.Q<VisualElement>("VE_NextLevel");
        btnContinueNL = root.Q<Button>("Btn_ContinueNL");
        btnRestartNL = root.Q<Button>("Btn_RestartNL");
        btnHomeNL = root.Q<Button>("Btn_HomeNL");

        // Initial VE States
        veGameplay.style.display = DisplayStyle.Flex;
        vePause.style.display = DisplayStyle.None;
        veNextLevel.style.display = DisplayStyle.None;

        // Button Functions
        btnSettings.clicked += () => BFuncChangeVE(1);

        btnContinueP.clicked += () => BFuncChangeVE(0);
        // btnRestartP.clicked += () => BFuncChangeVE(4);
        btnHomeP.clicked += () => BFuncChangeVE(5);

        btnContinueNL.clicked += () => BFuncChangeVE(3);
        // btnRestartNL.clicked += () => BFuncChangeVE(4);
        btnHomeP.clicked += () => BFuncChangeVE(5);

        DisplayTasks(lvl_Option);

    } // -- OnEnable Function

    void BFuncChangeVE(int num) {
        switch(num) {
            case 0:     // Gameplay VE
                veGameplay.style.display = DisplayStyle.Flex;
                vePause.style.display = DisplayStyle.None;
                veNextLevel.style.display = DisplayStyle.None;
                break;
            case 1:     // Pause VE
                veGameplay.style.display = DisplayStyle.None;
                vePause.style.display = DisplayStyle.Flex;
                veNextLevel.style.display = DisplayStyle.None;
                break;
            case 2:     // Next Level VE
                veGameplay.style.display = DisplayStyle.None;
                vePause.style.display = DisplayStyle.None;
                veNextLevel.style.display = DisplayStyle.Flex;
                break;
            case 3:     // New Level VE
                break;
            case 4:     // Restart Level VE
                break;
            case 5:     // Home VE
                break;
            default:
                break;
        }
    } //-- Button Function Change VE

    void DisplayTasks(int option) {
        switch(option) {
            case 1:
                lblLevel.text = "Level " + option.ToString();
                lblTask1.text = "Level 1 - Task 1";
                lblTask2.text = "Level 1 - Task 2";
                lblTask3.text = "Level 1 - Task 3";
                break;
            case 2:
                lblLevel.text = "Level " + option.ToString();
                lblTask1.text = "Level 2 - Task 1";
                lblTask2.text = "Level 2 - Task 2";
                lblTask3.text = "Level 2 - Task 3";
                break;
            case 3:
                lblLevel.text = "Level " + option.ToString();
                lblTask1.text = "Level 3 - Task 1";
                lblTask2.text = "Level 3 - Task 2";
                lblTask3.text = "Level 3 - Task 3";
                break;
            case 4:
                lblLevel.text = "Level " + option.ToString();
                lblTask1.text = "Level 4 - Task 1";
                lblTask2.text = "Level 4 - Task 2";
                lblTask3.text = "Level 4 - Task 3";
                break;
            default:
                break;
        }
    }
}


/*

Made by : Rey M. Oronos, Jr.
Project : Pool Shot

*/