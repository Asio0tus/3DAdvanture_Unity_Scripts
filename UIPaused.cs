using SimpleFPS;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPaused : MonoBehaviour
{
    [HideInInspector] public bool paused;
    [SerializeField] private GameObject menuPause;
    [SerializeField] private GameObject player;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) == true)
        {
            SwitchGamePause();
        }
    }

    public void SwitchGamePause()
    {
        
        if (paused == false)
        {
            Time.timeScale = 0;
            paused = true;
            menuPause.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            player.GetComponent<FirstPersonController>().enabled = false;
        }
        else
        {
            Time.timeScale = 1;
            paused = false;
            menuPause.SetActive(false);
            Cursor.visible = false;
            player.GetComponent<FirstPersonController>().enabled = true;
        }
    }
}
