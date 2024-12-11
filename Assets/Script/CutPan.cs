using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutPan : MonoBehaviour
{
    [SerializeField] private GameObject fueru;
    int rand;
    // Start is called before the first frame update
    private void Start()
    {
        Application.targetFrameRate = 60;
    }
    private void Update()
    {
        rand = Random.Range(0, 100);
        if (skillauto.SkillTreeauto == true)
        {
            if (rand == 50)
            {
                var _fuer = Instantiate(fueru, new Vector2(-1, 0), Quaternion.identity);
                _fuer.transform.localScale = Vector2.one * 0.5f;
            }
        }
        if (gikopa.gikogiko < 100)
        {

            if (Input.GetMouseButtonDown(0))
            {
                for (int i = 0; i < knifeup.KU + 1; i++)
                {
                    if (rand < criticalcount.CC * 2)
                    {
                        for (int j = 0; i < criticaldmgcount.CC * 20; i++)
                        {
                            var _fuer = Instantiate(fueru, new Vector2(-1, 0), Quaternion.identity);
                            _fuer.transform.localScale = Vector2.one * 0.5f;
                        }
                    }
                    var _fueru = Instantiate(fueru, new Vector2(-1, 0), Quaternion.identity);
                    _fueru.transform.localScale = Vector2.one * 0.5f;
                } 
            }
            
        } 
    }
            
}