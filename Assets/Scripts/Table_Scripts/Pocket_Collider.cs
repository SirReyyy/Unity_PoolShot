using UnityEngine;

public class Pocket_Collider : MonoBehaviour {
    private void OnTriggerEnter(Collider collider) {
        Debug.Log("Pocket");

        /*BallController cueBall = collider.gameObject.GetComponent<CueBallController>();
        
        if (cueBall != null)
            cueBall.BallPocketed();*/
    }
}


/*

Made by : Rey M. Oronos, Jr.
Project : 

*/