using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameSetup : MonoBehaviour
{
    public static GameSetup GS;

    public TextMeshProUGUI healthDisplay;

    public Transform[] spawnPoints;
    
    void OnEnable()
    {
        if (GameSetup.GS == null)
        {
            GameSetup.GS = this;
        }
    }
}
