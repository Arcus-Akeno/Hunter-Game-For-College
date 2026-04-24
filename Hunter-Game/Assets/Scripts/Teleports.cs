using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Teleports : MonoBehaviour
{
    [SerializeField] private AudioSource TeleportSoundclip;
    public Transform player;
    public Transform StartLocation;
    public Transform Location1;
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
    public KeyCode Teleport1;
    //left
    public KeyCode Teleport2;
    //right
     void Update()
     {
        if (Input.GetKeyDown(Teleport2))
        {
            player.transform.position = StartLocation.transform.position;

            
            AudioSource.Play();
        }




        if (Input.GetKeyDown(Teleport1))
        {
            player.transform.position = Location1.transform.position;
            
            AudioSource.Play();
            
        }
        
        
     }
    
}
