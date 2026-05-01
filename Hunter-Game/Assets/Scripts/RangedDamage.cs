using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.Entities;

public class RangedDamage : MonoBehaviour
{
    public float Damage;
    public float BulletRange;
    private Transform PlayerCamera;
    private void Start()
    {
        PlayerCamera = Camera.main.transform;
    }

    // Update is called once per frame
    public void shoot ()
    {
        Ray gunRay = new Ray(PlayerCamera.position, PlayerCamera.forward);
        if (Physics.Raycast(gunRay,out RaycastHit hitInfo, BulletRange))
        {
            if (hitInfo.collider.gameObject.TryGetComponent(out Targets enemy))
            {
                enemy.Health -= Damage;
            }
        }
    }
}
