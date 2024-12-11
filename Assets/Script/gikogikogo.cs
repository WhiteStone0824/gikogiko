using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gikogikogo : MonoBehaviour

{
    [SerializeField] private GameObject fueru;
    [SerializeField] private GameObject next;
    public static bool gii = true;
    void start()
    {
        gii = true;
    }

    void Update()
    {
        float rnd = Random.Range(0.0f, 15.0f) - 8;
        float size = Random.Range(0.3f, 1.0f);
        var _fueru = Instantiate(fueru, new Vector2(rnd, 10), Quaternion.identity);
        _fueru.transform.localScale = Vector2.one * size;
    }
    public void Letgikogikogo()
    {
        next.gameObject.SetActive(true);
    }

    public void toziru()
    {
        skillauto.SkillTreeauto = false;
        skillbigbang.SkillTreebigbang = false;
        skillcritical.SkillTreeCriticalNotPer = false;
        skillcriticaldmg.SkillTreecriticaldmg = false;
        skillcriticalper.SkillTreecriticalper = false;
        skillknifeUP.SkillTreeknifeUP = false;
        skillmagma.SkillTreemagma = false;
        skillpoint.SP = 0;
        skillsumonn.SkillTreesumonn = false;
        skillsun.SkillTreesun = false;
        skilltoaster.SkillTreeToaster = false;
        criticalcount.CC = 0;
        criticaldmgcount.CC = 0;
        gikopa.gikogiko = 0;
        knifeup.KU = 0;
        CutIn.Cutincut = false;
        SceneManager.LoadScene("Gikogiko");
    }
}
