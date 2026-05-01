using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class BulletTracers : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject Fire;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shooting();
        }
        
    }

    public void Shooting()
    {
        RaycastHit hit;

        if (Physics.Raycast(FirePoint.position, transform.TransformDirection(Vector3.forward) , out hit , 100))
        {
            Debug.DrawRay(FirePoint.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);

            Instantiate(FirePoint, FirePoint.position, Quaternion.identity);
           
        }


      
    }

}
