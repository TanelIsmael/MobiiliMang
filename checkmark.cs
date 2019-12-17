using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkmark : MonoBehaviour {

    public static checkmark Instance;
    // Use this for initialization
    void Awake()
    {

        if (Instance)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

    }
}
