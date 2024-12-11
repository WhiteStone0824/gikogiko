using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class aho : MonoBehaviour
{

    [SerializeField]private Image img;
    [SerializeField]private TextMeshProUGUI text;
    private void start()
    {
        CutIn.Cutincut = false;
        img.color = Color.white;
        text.SetText("CutInSkip:OFF");
    }
    public void cutinskip()
    {
        if (CutIn.Cutincut == false)
        {
            CutIn.Cutincut = true;
            img.color = Color.black;
            text.SetText("CutInSkip:ON");
        }
        else
        {
            CutIn.Cutincut = false;
            img.color = Color.white;
            text.SetText("CutInSkip:OFF");
        }
    }
}
