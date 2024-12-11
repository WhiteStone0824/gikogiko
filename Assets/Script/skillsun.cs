using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skillsun : MonoBehaviour
{
    public static bool SkillTreesun = false;
    [SerializeField] private GameObject next;
    void Start()
    {
        SkillTreesun = false;
    }

    public void critical()
    {
        if (skillsun.SkillTreesun == false)
        {
            if (skillpoint.SP > 0)
            {
                //GetComponent<Renderer>().material.color = Color.yellow;
                skillsun.SkillTreesun = true;
                skillpoint.SP--;
                next.gameObject.SetActive(true);
            }
        }
    }
}
