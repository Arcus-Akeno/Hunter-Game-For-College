using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;
public class SettingsMenu : MonoBehaviour
{

    [Range(0.1f, 0.3f)]
    public float camLookSpeed = 0.1f;
    [Range(0.1f, 0.3f)]
    public float camPivotSpeed = 0.1f;
    public Slider camLookSpeedSlider;
    public Slider camPivotSpeedSlider;
    private const string CamLookSpeedPrefKey = "CamLookSpeed";
    private const string CamLookPivotPrefKey = "CamPivotspeed";
    public float mouseSensitivity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void SetSensitivity (float slider)
    {
        Debug.Log(slider);
        mouseSensitivity = slider;
    }

    
    void Start()
    {
        camLookSpeed = PlayerPrefs.GetFloat(CamLookSpeedPrefKey, 0.1f);
        camPivotSpeed = PlayerPrefs.GetFloat(CamLookPivotPrefKey, 0.1f);

        camLookSpeedSlider.value = camLookSpeed;
        camPivotSpeedSlider.value = camPivotSpeed;

        camLookSpeedSlider.onValueChanged

    }
    public void SetCamLookSpeed(float value)
    {
        camLookSpeed = value;
        PlayerPrefs.SetFloat(CamLookSpeedPrefKey, camLookSpeed);
        PlayerPrefs.Save();
    }

    public void SetCamPivotSpeed(float value)
    {
        camPivotSpeed = value;
        PlayerPrefs.SetFloat(CamLookPivotPrefKey, camPivotSpeed);
        PlayerPrefs.Save();
    }
}
