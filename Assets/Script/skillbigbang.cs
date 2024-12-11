using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skillbigbang : MonoBehaviour
{
    public static bool SkillTreebigbang = false;
    [SerializeField] private GameObject next;
    void Start()
    {
        SkillTreebigbang = false ;
    }

    public void critical()
    {
        if (skillbigbang.SkillTreebigbang == false)
        {
            if (skillpoint.SP > 0)
            {
                //GetComponent<Renderer>().material.color = Color.yellow;
                skillbigbang.SkillTreebigbang = true;
                skillpoint.SP--;

                if (skillsumonn.SkillTreesumonn == true)
                {
                    if (skillcriticalper.SkillTreecriticalper == true)
                    {
                        if (skillcriticaldmg.SkillTreecriticaldmg == true)
                        {
                            next.gameObject.SetActive(true);
                        }
                    }
                }
                
            }
        }
    }
}
