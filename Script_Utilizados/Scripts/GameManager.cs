using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public OutfitChanger outfitChanger; 

    private void Start()
    {
        if (outfitChanger != null)
        {
            LoggingOutfitChanger loggingOutfitChanger = new LoggingOutfitChanger(outfitChanger);
        }
        else
        {
            Debug.LogError("OutfitChanger not assigned in the Inspector.");
        }
    }
}
