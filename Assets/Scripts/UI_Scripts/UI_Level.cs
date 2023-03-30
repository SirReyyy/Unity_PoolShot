using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UI_Level : MonoBehaviour {

    public SceneManagerScript _sceneManagerScript;

    public VisualElement veGameplay, vePause, veNextLevel;
    public Button btnSettings, btnContinueP, btnRestartP, btnHomeP;
    public Button btnContinueNL, btnRestartNL, btnHomeNL;
    public Label lblLevel, lblTask1, lblTask2, lblTask3;


    private int lvl_Option = PersistentManagerScript.Instance.Level_Option;
    private bool task1_Status, task2_Status, task3_Status;

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
        btnRestartP.clicked += () => BFuncChangeVE(3);
        btnHomeP.clicked += () => BFuncChangeVE(5);

        btnContinueNL.clicked += () => BFuncChangeVE(4);
        btnRestartNL.clicked += () => BFuncChangeVE(3);
        btnHomeNL.clicked += () => BFuncChangeVE(5);

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
            case 3:     // Restart Level VE
                PersistentManagerScript.Instance.Level_Option = lvl_Option;
                _sceneManagerScript.LoadLevelScene();
                break;
            case 4:     // New Level VE
                PersistentManagerScript.Instance.Level_Option = lvl_Option + 1;
                _sceneManagerScript.LoadLevelScene();
                break;
            case 5:     // MenuScene - veMenu
                PersistentManagerScript.Instance.Level_Option = 0;
                _sceneManagerScript.LoadMenuScene(); 
                break;
            default:
                break;
        }
    } //-- Button Function Change VE

    void DisplayTasks(int option) {
        lblLevel.text = "Level " + option.ToString();
        string level = lblLevel.text;
        
        if(!task1_Status)
            lblTask1.text = level + " - Task 1";
        else
            lblTask1.text = level + " - Task 1 (Completed)";
        
        if(!task2_Status)
            lblTask2.text = level + " - Task 2";
        else
            lblTask2.text = level + " - Task 2 (Completed)";
        
        if(!task3_Status)
            lblTask3.text = level + " - Task 3";
        else
            lblTask3.text = level + " - Task 3 (Completed)";
    } //-- DisplayTasks Function
}


/*

Made by : Rey M. Oronos, Jr.
Project : Pool Shot

*/