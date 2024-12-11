using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class skillpoint : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI str;
    public static int SP = 0;
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        str.SetText("Skillpoint:{0}", SP);
    }
}
