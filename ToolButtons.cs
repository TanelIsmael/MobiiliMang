using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.UI;

public class ToolButtons : MonoBehaviour
{
    
    public Sprite activeImage;
    public Sprite inactiveImage;
    public GameObject iconBG;
    public Button Main, Spooky, Glacier, Dark, Cherry;
    public GameObject MainTheme, SpookyTheme, GlacierTheme, DarknessTheme, CherryTheme;
    

    List<Button> button = new List<Button>();
    List<GameObject> iconGameObjects = new List<GameObject>();

    void pairButtonIcon()
    {
        button.Add(Main);
        iconGameObjects.Add(MainTheme);

        button.Add(Spooky);
        iconGameObjects.Add(SpookyTheme);

        button.Add(Glacier);
        iconGameObjects.Add(GlacierTheme);

        button.Add(Dark);
        iconGameObjects.Add(DarknessTheme);

        button.Add(Cherry);
        iconGameObjects.Add(CherryTheme);


    }

    

    void Start()
    {
        
       
        pairButtonIcon();
        inactiveImage = iconBG.GetComponent<Image>().sprite;
        
        

    }

    // Use this for initialization
    void buttonCallBack(Button buttonClicked)
    {

        //My Code
        for (int i = 0; i < button.Count; i++)
        {
            if (buttonClicked == button[i])
            {
                iconGameObjects[i].GetComponent<Image>().sprite = activeImage;
                
            }
            else
            {
                iconGameObjects[i].GetComponent<Image>().sprite = inactiveImage;
                
            }

            
        }
    }

    void OnEnable()
    {
        Main.onClick.AddListener(() => buttonCallBack(Main));
        Spooky.onClick.AddListener(() => buttonCallBack(Spooky));
        Glacier.onClick.AddListener(() => buttonCallBack(Glacier));
        Dark.onClick.AddListener(() => buttonCallBack(Dark));
        Cherry.onClick.AddListener(() => buttonCallBack(Cherry));
        
    }


    void OnDisable()
    {

    }
}