using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int currentposition = 0;
    void Start()
    {
        transform.position = gamecontrol.instance.tiles[currentposition].transform.position;
    }
    public void movebydice ()
    {
        int numberofmoves = gamecontrol.instance.roll;
        for (int i = numberofmoves; i>0; i --)
        {
            if (currentposition > 6)
            {
                currentposition = 0;
            }
            movestep();
        }
    }
    public void movestep ()
    {
        transform.position = gamecontrol.instance.tiles[currentposition + 1].transform.position;
        currentposition++;
    }
    void Update()
    {
        
    }
}
