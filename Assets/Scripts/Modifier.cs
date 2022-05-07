using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Modifier : MonoBehaviour
{
    public Text targetText;

    public void Modify()
    {
        targetText.fontSize++;
    }
}
