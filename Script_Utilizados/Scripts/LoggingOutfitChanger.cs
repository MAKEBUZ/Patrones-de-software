using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoggingOutfitChanger : OutfitChangerDecorator
{
    public LoggingOutfitChanger(OutfitChangerBase outfitChanger) : base(outfitChanger) { }

    public override void NextOption()
    {
        Debug.Log("Next option selected");
        base.NextOption();
    }

    public override void PreviousOption()
    {
        Debug.Log("Previous option selected");
        base.PreviousOption();
    }
}
