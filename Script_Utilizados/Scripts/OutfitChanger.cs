using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutfitChanger : OutfitChangerBase
{
    [Header("Sprite To Change")]
    public SpriteRenderer bodyPart;

    [Header("Sprites to Cycle Through")]
    public List<Sprite> options = new List<Sprite>(); 

    private int currentOption = 0;

    public override void NextOption()
    {
        currentOption++;
        if (currentOption >= options.Count)
        {
            currentOption = 0; 
        }

        bodyPart.sprite = options[currentOption];
    }

    public override void PreviousOption()
    {
        currentOption--;
        if (currentOption < 0)
        {
            currentOption = options.Count - 1; 
        }

        bodyPart.sprite = options[currentOption];
    }
}

