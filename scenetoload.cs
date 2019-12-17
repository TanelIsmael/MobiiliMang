using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scenetoload : MonoBehaviour
{

   

    private string sceneToLoad;
    private int sceneIndex;
    [SerializeField]
    private string[] scenes;
    public static int cost;
    public Color colorToLoad = Color.white;
    
    







    void Start()

    {
        
        SelectScene(ThemeSaver.Instance.currentThemeIndex);
        


    }
    

    public void SelectScene(int index)
    {
        

        if ((ThemeSaver.Instance.themeAvailability & 1 << index) == 1 << index)
        {


            sceneToLoad = scenes[index];
            ThemeSaver.Instance.currentThemeIndex = index;
            ThemeSaver.Instance.Save();
            
        }
        else
        {
            cost = 1;

            if (CoinManager.Instance.Coins >= cost)
            {


                CoinManager.Instance.Coins -= cost;
                PlayerPrefs.SetInt("COINS", CoinManager.Instance.Coins);
                ThemeSaver.Instance.themeAvailability += 1 << index;
                ThemeSaver.Instance.Save();
                
                SelectScene(index);

                






            }
            

            

        }


    }
   

    public void LoadSelectedScene ()
    {
        SoundManager.Instance.PlaySound(SoundManager.Instance.hitButton);
        
        Initiate.Fade(sceneToLoad, colorToLoad, 2.0f);
    }
}
