using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class criticaldmgcount : MonoBehaviour 
{
    [SerializeField] private TextMeshProUGUI str;
    public static int CC = 0;
    private void Start()
    {
        CC = 0;
    }

    // Update is called once per frame
    private void Update()
    {
        str.SetText("{0}/5", CC);
    }
}
