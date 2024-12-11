using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skilltoaster : MonoBehaviour
{
    public static bool SkillTreeToaster = false;
    [SerializeField] private GameObject next;
    void Start()
    {
        SkillTreeToaster = false;
    }

    public void critical()
    {
        if (skilltoaster.SkillTreeToaster == false)
        {
            if (skillpoint.SP > 0)
            {
                //GetComponent<Renderer>().material.color = Color.yellow;
                skilltoaster.SkillTreeToaster = true;
                skillpoint.SP--;
                next.gameObject.SetActive(true);
            }
        }
    }
}
