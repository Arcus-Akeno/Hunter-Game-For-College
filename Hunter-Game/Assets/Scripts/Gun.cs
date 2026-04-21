using UnityEngine;
using UnityEngine.Events;
public class Gun : MonoBehaviour
{

    public UnityEvent OnGunShoot;
    public float FireCooldown;
    private float CurrentCooldown;
    void Start()
    {
        CurrentCooldown = FireCooldown;
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            if(CurrentCooldown <= 0f)
            {
                OnGunShoot?.Invoke();
                CurrentCooldown = FireCooldown;


            }
        }


        CurrentCooldown -= Time.deltaTime;

    }
}
