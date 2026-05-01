using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Teleports : MonoBehaviour
{
    [SerializeField] private AudioSource TeleportSoundclip;
    public Transform player;
    public Transform StartLocation;
    public Transform Location1;
    public Transform Location2;
    private AudioSource AudioSource;

    
    private void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }
    public void TeleportStart()
    {
        player.transform.position = StartLocation.transform.position;

    }
    public void TeleportLocation1()
    {
        player.transform.position = Location1.transform.position;

    }
    public void TeleportLocation2()
    {
        player.transform.position = Location2.transform.position;

    }
    public KeyCode TeleportMid;
    //Is Start Location
    public KeyCode TeleportLeft;
    //Is location 1
    public KeyCode TeleportRight;
    //Is location 2
    void Update()
     {
        if (Input.GetKeyDown(TeleportMid))
        {
            player.transform.position = StartLocation.transform.position;

            
            AudioSource.Play();
        }

        if (Input.GetKeyDown(TeleportRight))
        {
            player.transform.position = Location2.transform.position;


            AudioSource.Play();
        }


        if (Input.GetKeyDown(TeleportLeft))
        {
            player.transform.position = Location1.transform.position;
            
            AudioSource.Play();
            
        }
        
        
     }
    
}
