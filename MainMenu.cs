using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public Button ThemeButton;
    public Button CreditsButton;

    public GameObject ThemeMenu;
    public GameObject CreditsMenu;



    public void OpenThemeMenu()
    {
        ThemeMenu.SetActive(true);
    }

    public void OpenCreditsMenu()
    {
        CreditsMenu.SetActive(true);
    }


}
