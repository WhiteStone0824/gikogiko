using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skillknifeUP : MonoBehaviour
{
    public static bool SkillTreeknifeUP = false;
    [SerializeField] private GameObject next;
    [SerializeField] private Image img;
    void Start()
    {
        knifeup.KU = 0;
    }

    public void critical()
    {
        if (skillknifeUP.SkillTreeknifeUP == false)
        {
            if (knifeup.KU != 9)
            {
                if (skillpoint.SP > 0)
                {
                    if (knifeup.KU == 8)
                    {
                        //this.GetComponent<SpriteRenderer>().color = Color.yellow;
                        skillknifeUP.SkillTreeknifeUP = true;
                        next.SetActive(true);
                        img.color = Color.yellow;
                    }
                    knifeup.KU ++;
                    skillpoint.SP--;
                }
            }
        }
    }
}
