using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyMinus : Modifier
{
    public override void Modify()
    {
        targetText.fontSize--;
    }
}
