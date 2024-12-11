using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skillcritical : MonoBehaviour
{
    public static bool SkillTreeCriticalNotPer = false;
    [SerializeField] private GameObject next;
    [SerializeField] private GameObject prev;
    void Start()
    {
        SkillTreeCriticalNotPer = false;
    }

    public void critical()
    {
        if (skillcritical.SkillTreeCriticalNotPer == false)
        {
            if (skillpoint.SP > 0)
            {
                //GetComponent<Renderer>().material.color = Color.yellow;
                skillcritical.SkillTreeCriticalNotPer = true;
                skillpoint.SP--;
                next.gameObject.SetActive(true);
                prev.gameObject.SetActive(true);
            }
        }
    }
}
