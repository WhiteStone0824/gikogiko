using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skillsumonn : MonoBehaviour
{
    public static bool SkillTreesumonn = false;
    [SerializeField] private GameObject next;
    void Start()
    {
        SkillTreesumonn = false;
    }

    public void critical()
    {
        if (skillsumonn.SkillTreesumonn == false)
        {
            if (skillpoint.SP > 0)
            {
                //GetComponent<Renderer>().material.color = Color.yellow;
                skillsumonn.SkillTreesumonn = true;
                skillpoint.SP--;

                if (skillbigbang.SkillTreebigbang == true)
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
