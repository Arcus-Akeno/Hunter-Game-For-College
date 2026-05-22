using UnityEditor;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [Header("Menu Objects")]
    [SerializeField] private GameObject ESCmenuCanvasGO;
    [SerializeField] private GameObject MainmenuCanvasGO;
    [SerializeField] private GameObject SettingsMenuCanvasGO;
    [Header("Player Scripts to deactivate on pause")]
    [SerializeField] private CameraController CameraController;
    [SerializeField] private Gun Gun;
    
    private bool ispaused;
   private void Start()
    {
        ESCmenuCanvasGO.SetActive(false);
        MainmenuCanvasGO.SetActive(false);
        SettingsMenuCanvasGO.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (InputManager.instance.MenuOpenCloseInput)
        {
            if (!ispaused)
            {
                pause();
            }
            else
            {
                Unpause();
            }
        }
    }



    #region pause/unpause functions

    public void pause()
    {
        ispaused = true;
        Time.timeScale = 0f;
        Cursor.visible = true;
        CameraController.enabled = false;
        Gun.enabled = false;


        OpenMainMenu();
    }

    public void Unpause()
    {
        ispaused = false;
        Time.timeScale = 1f;
        Cursor.visible = false;
        CameraController.enabled = true;
        Gun.enabled = true;
        CloseAllMenus();
    }
    #endregion
    #region  Canvas Activation
    
    private void OpenMainMenu()
    {
        ESCmenuCanvasGO.SetActive(true);
        MainmenuCanvasGO.SetActive(false);
        SettingsMenuCanvasGO.SetActive(false);
    }

    private void OpenSettingsMenuHandle()
    {
        SettingsMenuCanvasGO.SetActive(true);
        ESCmenuCanvasGO.SetActive(true);
        MainmenuCanvasGO.SetActive(false);
    }
    private void CloseAllMenus()
    {
        ESCmenuCanvasGO.SetActive(false);
        MainmenuCanvasGO.SetActive(false);
        SettingsMenuCanvasGO.SetActive(false);

    }

    #endregion
    

    public void OnSettingsPress()
    {
        OpenSettingsMenuHandle();
    }

    public void OnResumePress()
    {
        Unpause();
    }

    public void OnsettingsBackPress()
    {
        OpenMainMenu();
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

