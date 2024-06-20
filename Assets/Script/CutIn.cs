using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutIn : MonoBehaviour
{
    [SerializeField] private GameObject cutinpng;
    [SerializeField] private GameObject cutinvideo;
    bool giko ;
    void gik()
    {
        gikopa.gikogiko -= 100;
        giko = false;
        cutinvideo.gameObject.SetActive(false);
    }
    void gi()
    {
        
        cutinpng.gameObject.SetActive(false);
        cutinvideo.gameObject.SetActive(true);
        Invoke("gik",12);
        Debug.Log("cut");
    }
    float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        cutinpng.gameObject.SetActive(false);
        cutinvideo.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (giko == false)
        {

            if (gikopa.gikogiko >= 100)
            {
                giko = true;
                cutinpng.gameObject.SetActive(true);
                Invoke("gi", 2);
            }
        }
    } 
}

    

