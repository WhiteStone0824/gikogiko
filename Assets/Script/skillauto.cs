using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skillauto : MonoBehaviour
{
    public static bool SkillTreeauto = false;
    [SerializeField] private GameObject next;
    void Start()
    {
       skillauto.SkillTreeauto = false;
    }

    private void Update()
    {
        Debug.Log(skillauto.SkillTreeauto);
    }
    public void critical()
    {
        if (skillauto.SkillTreeauto == false)
        {
            if (skillpoint.SP > 0)
            {
                //GetComponent<Renderer>().material.color = Color.yellow;
                skillauto.SkillTreeauto = true;
                skillpoint.SP--;
                next.gameObject.SetActive(true);
            }
        }
    }
}
