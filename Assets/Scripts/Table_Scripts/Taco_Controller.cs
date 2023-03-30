using UnityEngine;

public class Taco_Controller : MonoBehaviour {
    [SerializeField]
    private Transform _CueBall = null;

    private float DefaultDistFromCueBall;

    private float MxClampDist = 9;


    private float ForceGathered = 0.0f;
    public float ForceGatheredToHit { get { return ForceGathered;  } }

    private float ForceThreshold = 0.5f;

    private float ForceSpeed = 10.0f;
    private bool TacoReleasedToStrike = false;

    
    private Vector3 CueBallInitialPos;
    private Vector3 CueBallInitialDir;

    
    private Vector3 PosToRot = Vector3.one;

    private void Start() {
        CueBallInitialPos = transform.position;
        CueBallInitialDir = transform.forward;

        DefaultDistFromCueBall = Vector3.Distance(_CueBall.position, transform.position);
        }
}


/*

Made by : Rey M. Oronos, Jr.
Project : 

*/