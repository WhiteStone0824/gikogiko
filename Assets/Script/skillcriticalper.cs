using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skillcriticalper : MonoBehaviour
{
    public static bool SkillTreecriticalper = false;
    [SerializeField] private GameObject next;
    [SerializeField] private Image img;
    void Start()
    {
        //GetComponent<Renderer>().material.color = Color.white;
    }

    public void critical()
    {
        if (skillcriticalper.SkillTreecriticalper == false)
        {
            if (criticalcount.CC != 5)
            {
                if (skillpoint.SP > 0)
                {
                    if (criticalcount.CC == 4)
                    {
                        img.color = Color.yellow;
                        skillcriticalper.SkillTreecriticalper = true;
                        if (skillbigbang.SkillTreebigbang == true)
                        {
                            //GetComponent<Renderer>().material.color = Color.yellow;
                            if (skillsumonn.SkillTreesumonn == true)
                            {
                                if (skillcriticaldmg.SkillTreecriticaldmg == true) 
                                { 
                                    next.SetActive(true);
                                }
                            }
                        }
                    }
                    criticalcount.CC ++;
                    skillpoint.SP--;
                }
            }
        }
    }
}
