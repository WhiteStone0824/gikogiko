using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knifeMove : MonoBehaviour
{
    [SerializeField] private Animator anime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gikopa.gikogiko < 100)
        {
            if (Input.GetMouseButtonDown(0))
            {
                anime.Play("cutdown");
            } 
        }
    }
}
