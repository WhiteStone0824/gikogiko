using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class gobacktitle : MonoBehaviour
{
    private float step_time;

    // Start is called before the first frame update
    void Start()
    {
        step_time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        step_time += Time.deltaTime;
        if (step_time > 60.0f) SceneManager.LoadScene("title");

        
        if(Input.GetAxis("Mouse X") != 0) step_time = 0.0f;


        if(Input.GetAxis("Mouse Y") != 0) step_time = 0.0f;


        if (Input.GetMouseButtonDown(0)) step_time = 0.0f;
    }
}
