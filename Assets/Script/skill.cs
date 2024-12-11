using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skill : MonoBehaviour
{
    [SerializeField] Image img;
    // Start is called before the first frame update
    public void ColorChange()
    {
        if (skillpoint.SP > 0)
        {
            img.color = Color.yellow;
        }
    }

}
