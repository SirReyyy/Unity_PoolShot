using UnityEngine;



public class PersistentManagerScript : MonoBehaviour {
    
    public static PersistentManagerScript Instance { get; private set; }

    // Variables
    public int Level_Option = 0, FreePlay_Option = 0;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    } // -- Awake Function
}


/*

Made by : Rey M. Oronos, Jr.
Project : Pool Shot

*/