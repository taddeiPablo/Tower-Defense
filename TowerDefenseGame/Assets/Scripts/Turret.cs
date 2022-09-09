using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{

    // Instance of the class
    [Header("Turret Attributes")]
    public static Turret instance;
    public Transform Shootpoint;
    public GameObject bullet;

    [Header("Turret Properties")]
    public int lives = 5;
    public int CurrentLives = 5;
    public float ViewDistance;
    public float FireRate;
    public float Force;
    public float speed = 1.5f;
    public bool isChildTurret = false;

    private float nextTimeToFire = 0;
    private Transform Target;
    private Vector3 closeEnemyRef;
    private Vector2 Direction;
    private bool Detected = false;


    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
