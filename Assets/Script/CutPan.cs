using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutPan : MonoBehaviour
{
    [SerializeField] private GameObject fueru;
    float time = 0f;
    // Start is called before the first frame update
    private void Start()
    {
        Application.targetFrameRate = 60;
    }
    private void Update()
    {
        if (gikopa.gikogiko < 100)
        {

            if (Input.GetMouseButtonDown(0))
            {
                var _fueru = Instantiate(fueru, new Vector2(-0.5f, 0), Quaternion.identity);

                _fueru.transform.localScale = Vector2.one * 0.5f;

            }
        }
    }

}