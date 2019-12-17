using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingChaotic : MonoBehaviour
{
    public string scene;
    public Color loadToColor = Color.white;

    void Start()
    {
        Invoke("loadingLogo", 3f);
    }
    void loadingLogo()
    {
        Initiate.Fade(scene, loadToColor, 3f);
    }
}
