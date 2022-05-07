using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyPlus : Modifier
{
    public override void Modify()
    {
        targetText.fontSize++;
    }
}
