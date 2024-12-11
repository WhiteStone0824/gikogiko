using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class knifeup : MonoBehaviour 
{
    [SerializeField] private TextMeshProUGUI str;
    public static int KU = 0;
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {
        str.SetText("{0}/9", KU);
    }
}
