using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gikopa : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI num;
    Slider gikopaSlider;
    //ï\é¶Ç∑ÇÈïœêî
    public static int gikogiko = 0;
    void Start()
    {
        
    }
    void Update()
    {
        num.SetText("GikoGikoEnergy{0:000}%", gikogiko);
        gikopaSlider = GetComponent<Slider>();
        gikopaSlider.value = gikogiko;
    }
}