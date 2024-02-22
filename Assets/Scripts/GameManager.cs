using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject NPC;
    public GameObject UI;

    private void Update()
    {
        if (Distance() <= 2f)
            UI.SetActive(true);
        else
            UI.SetActive(false);
    }

    private float Distance()
    {
        float distance = Vector2.Distance(Player.transform.position, NPC.transform.transform.position) ;
        return distance;
    }
}
