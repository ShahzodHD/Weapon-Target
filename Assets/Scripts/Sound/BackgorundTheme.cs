using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgorundTheme : MonoBehaviour
{
    [SerializeField] private GameObject BGMusic;
    [SerializeField] private GameObject[] soundObj;

    void Awake()
    {
        soundObj = GameObject.FindGameObjectsWithTag("Sound"); 
        if (soundObj.Length == 0)
        {
            BGMusic = Instantiate(BGMusic); 
            BGMusic.name = "BGMusic"; 
            DontDestroyOnLoad(BGMusic.gameObject); 
        }
        else
        {
            BGMusic = GameObject.Find("BGMusic");
        }
    }
}
