using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform player;
    public Transform startLoc;
    public Transform Loc1;

    public void TeleStart()
    {
        player.transform.position = startLoc.transform.position;

    }

    public void TeleLoc1()
    {
        player.transform.position = Loc1.transform.position;
    }
}
