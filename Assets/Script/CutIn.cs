using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutIn : MonoBehaviour
{
    [SerializeField] private GameObject cutinpng;
    [SerializeField] private GameObject cutinvideo;
    [SerializeField] private GameObject skilltree;
    [SerializeField] private GameObject aho;
    bool giko = false;
    public static bool Cutincut;
    void gik()
    {
        cutinpng.gameObject.SetActive(false);
        cutinvideo.gameObject.SetActive(false);
        skillpoint.SP+= gikopa.gikogiko/100;
        gikopa.gikogiko = 0;
        skilltree.SetActive(true);
        aho.SetActive(true);
        giko = false ;
        
    }
    void gi()
    {
        if (Cutincut == false)
        {
            cutinvideo.gameObject.SetActive(true);

            Invoke("gik", 12);

            Debug.Log("cut");
        }
        else if (Cutincut == true)
        {
            skillpoint.SP += gikopa.gikogiko / 100;
            cutinpng.gameObject.SetActive(false);
            gikopa.gikogiko = 0;
            skilltree.SetActive(true);
            aho.SetActive(true);
            giko = false;
        }
    }
    float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        cutinpng.gameObject.SetActive(false);
        cutinvideo.gameObject.SetActive(false);
        Cutincut = true;
        
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
                skilltree.gameObject.SetActive(false);
                aho.SetActive(false);
                Invoke("gi", 2);
            }
        }
    } 
}

    

