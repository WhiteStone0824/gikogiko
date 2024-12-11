using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skillmagma : MonoBehaviour
{
    public static bool SkillTreemagma = false;
    [SerializeField] private GameObject next;
    void Start()
    {
        SkillTreemagma = false;
    }

    public void critical()
    {
        if (skillmagma.SkillTreemagma == false)
        {
            if (skillpoint.SP > 0)
            {
                //GetComponent<Renderer>().material.color = Color.yellow;
                skillmagma.SkillTreemagma = true;
                skillpoint.SP--;
                next.gameObject.SetActive(true);
            }
        }
    }
}
