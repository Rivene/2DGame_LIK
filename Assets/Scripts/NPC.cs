using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject Player;
    public SpriteRenderer Peng;

    private void Update()
    {
        if (gameObject.transform.position.x - Player.transform.position.x > 0)
            Peng.flipX = true;
        else
            Peng.flipX = false;
    }
}
