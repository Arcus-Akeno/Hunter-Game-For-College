using UnityEngine;
using UnityEngine.Events;
public class Gun : MonoBehaviour
{

    public UnityEvent OnGunShoot;
    public float FireCooldown;
    private float CurrentCooldown;

    [SerializeField]
    AudioSource audio;
    RangedDamage RangedDamageScript;
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

                OnGunShoot.Invoke();
                audio.Play();
                CurrentCooldown = FireCooldown;
            }
        }


        CurrentCooldown -= Time.deltaTime;

    }
}
