using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private GameObject WinText;
    [SerializeField] private GameObject LoseText;
    
    public void playerDie()
    {
        LoseText.SetActive(true);
    }

    public void playerWin()
    {
        WinText.SetActive(true);
    }
}
 