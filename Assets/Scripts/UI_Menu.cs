using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UI_Menu : MonoBehaviour {
    public VisualElement veMainMenu, veLevels, veFreePlay;
    public Button btnStart, btnFreePlay, btnExit;
    public Button btnLvl1, btnLvl2, btnLvl3, btnLvl4, btnReturnL;
    public Button btn9Ball, btn15Ball, btnReturnFP;

    void OnEnable() {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        // Main Menu Container
        veMainMenu = root.Q<VisualElement>("VE_MainMenu");
        btnStart = root.Q<Button>("Btn_Start");
        btnFreePlay = root.Q<Button>("Btn_FreePlay");
        btnExit = root.Q<Button>("Btn_Exit");

        // Levels Container
        veLevels = root.Q<VisualElement>("VE_Levels");
        btnLvl1 = root.Q<Button>("Btn_Level_1");
        btnLvl2 = root.Q<Button>("Btn_Level_2");
        btnLvl3 = root.Q<Button>("Btn_Level_3");
        btnLvl4 = root.Q<Button>("Btn_Level_4");
        btnReturnL = root.Q<Button>("Btn_ReturnL");

        // Free Play Container
        veFreePlay = root.Q<VisualElement>("VE_FreePlay");
        btn9Ball = root.Q<Button>("Btn_9_Ball");
        btn15Ball = root.Q<Button>("Btn_15_Ball");
        btnReturnFP = root.Q<Button>("Btn_ReturnFP");

        // Initial VE States
        veMainMenu.style.display = DisplayStyle.Flex;
        veLevels.style.display = DisplayStyle.None;
        veFreePlay.style.display = DisplayStyle.None;

        // Button Functions
        btnStart.clicked += () => BFuncChangeVE(1);
        btnFreePlay.clicked += () => BFuncChangeVE(2);
        btnExit.clicked += () => BFuncChangeVE(3);

        btnReturnL.clicked += () => BFuncChangeVE(0);
        btnReturnFP.clicked += () => BFuncChangeVE(0);




    
    } // -- OnEnable Function

    void BFuncChangeVE(int num) {
        switch(num) {
            case 0:     // Main Menu VE
                veMainMenu.style.display = DisplayStyle.Flex;
                veLevels.style.display = DisplayStyle.None;
                veFreePlay.style.display = DisplayStyle.None;
                break;
            case 1:     // Levels VE
                veMainMenu.style.display = DisplayStyle.None;
                veLevels.style.display = DisplayStyle.Flex;
                veFreePlay.style.display = DisplayStyle.None;
                break;
            case 2:     // Free Play VE
                veMainMenu.style.display = DisplayStyle.None;
                veLevels.style.display = DisplayStyle.None;
                veFreePlay.style.display = DisplayStyle.Flex;
                break;
            case 3:     // Exit Game
                
                // Application.Quit(); called on Singleton?
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