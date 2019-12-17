using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemeSaver : MonoBehaviour
{

    private static ThemeSaver instance;
    public static ThemeSaver Instance { get { return instance; } }

    public int currentThemeIndex = 0;
    public int themeAvailability = 1;

    private void Awake()
    {
        instance = this; 
        DontDestroyOnLoad(gameObject);

        if (PlayerPrefs.HasKey("CurrentTheme"))
        {
            currentThemeIndex = PlayerPrefs.GetInt("CurrentTheme");
            themeAvailability = PlayerPrefs.GetInt("ThemeAvailability");
        }
        else
        {
            Save();
        }
    }

    public void Save()

    {
        PlayerPrefs.SetInt("CurrentTheme", currentThemeIndex);
        PlayerPrefs.SetInt("ThemeAvailability", themeAvailability);

    }




}
