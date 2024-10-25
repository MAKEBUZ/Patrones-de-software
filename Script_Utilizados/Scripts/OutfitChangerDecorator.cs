using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class OutfitChangerDecorator : OutfitChangerBase
{
    protected OutfitChangerBase _outfitChanger;

    public OutfitChangerDecorator(OutfitChangerBase outfitChanger)
    {
        _outfitChanger = outfitChanger;
    }

    public override void NextOption()
    {
        _outfitChanger.NextOption();
    }

    public override void PreviousOption()
    {
        _outfitChanger.PreviousOption();
    }
}
