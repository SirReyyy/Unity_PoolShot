using UnityEngine;

public class Ball_Controller : MonoBehaviour {
    public enum BallType {
        White = 0,
        Yellow,
        Blue,
        Red,
        Purple,
        Orange,
        Green,
        Burgandy,
        Black,
        Striped_Yellow,
        Striped_Blue,
        Striped_Red,
        Striped_Purple,
        Striped_Orange,
        Striped_Green,
        Striped_Burgandy,
    }

    [SerializeField]
    float BallForce = 30.0f;
    private Vector3 InitialPos;

    [SerializeField]
    BallType _ballType = BallType.White;

    public BallType _BallType { get { return _ballType; } }
}


/*

Made by : Rey M. Oronos, Jr.
Project : 

*/