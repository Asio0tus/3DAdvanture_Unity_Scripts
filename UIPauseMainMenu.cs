using SimpleFPS;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPauseMainMenu : MonoBehaviour
{
    [SerializeField] private UIPaused paused;    
    [SerializeField] private GameObject player;

    public void OnMainMenu()
    {
        Time.timeScale = 1;
        paused.paused = false;      
        
        player.GetComponent<FirstPersonController>().enabled = true;
    }
}
