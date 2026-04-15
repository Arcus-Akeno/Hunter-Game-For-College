using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Teleports : MonoBehaviour
{

    public Transform player;
    public Transform StartLocation;
    public Transform Location1;

    public void TeleportStart()
    {
        player.transform.position = StartLocation.transform.position;

    }
    public void TeleportLocation1()
    {
        player.transform.position = Location1.transform.position;

    }
}
