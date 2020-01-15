using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamecontrol : MonoBehaviour
{
    public int nooftiles = 6;
    public static gamecontrol instance;
    public GameObject player;
    public Transform[] tiles;
    public Text dicenumber;
    public int roll = 0;

    // singlton
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    else if ( instance != this)
        {
            Destroy(gameObject);
        }
        
    }

    private void FixedUpdate()
    {
        dicenumber.text = "" + roll;
    }
    void Update()
    {
        
    }
    public int diceroll ()
    {
        roll = Random.Range(1, 6);
        return roll;
    }
}
