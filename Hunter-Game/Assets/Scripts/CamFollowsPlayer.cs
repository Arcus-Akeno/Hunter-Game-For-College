using UnityEngine;

public class CamFollowsPlayer : MonoBehaviour
{
    public Transform cameraPosition;

    // Update is called once per frame
   private void Update()
    {
      transform.position = cameraPosition.position;  
    }
}
