using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skillcriticaldmg : MonoBehaviour
{
    public static bool SkillTreecriticaldmg = false;
    [SerializeField] private GameObject next;
    [SerializeField] private Image img;
    void Start()
    {
        //GetComponent<Renderer>().material.color = Color.white;
    }

    public void critical()
    {
        if (skillcriticaldmg.SkillTreecriticaldmg== false)
        {
            if (criticaldmgcount.CC != 5)
            {
                if (skillpoint.SP > 0)
                {
                    if (criticaldmgcount.CC == 4)
                    {
                        img.color = Color.yellow;
                        skillcriticaldmg.SkillTreecriticaldmg = true;
                        if (skillbigbang.SkillTreebigbang == true)
                        {
                            //GetComponent<Renderer>().material.color = Color.yellow;
                            if (skillsumonn.SkillTreesumonn == true)
                            {
                                if (skillcriticalper.SkillTreecriticalper == true)
                                    next.SetActive(true);
                            }
                    
                        }
                    }
                    criticaldmgcount.CC ++;
                    skillpoint.SP--;
                }
            }
        }
    }
}
