using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyPan : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField]private GameObject go;
    int rand;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5.5f)
        {
            if (SceneManager.GetActiveScene().name == "Gikogiko") 
            {
                gikopa.gikogiko++;
                if (skilltoaster.SkillTreeToaster == true)
                {
                    gikopa.gikogiko ++;
                    if (skillmagma.SkillTreemagma == true)
                    {
                        gikopa.gikogiko ++;
                        if(skillsun.SkillTreesun == true)
                        {
                            gikopa .gikogiko ++;
                            if(skillbigbang.SkillTreebigbang == true)
                            {
                                gikopa .gikogiko ++;
                            }
                        }
                    }
                }
            }
            rand = Random.Range(0,10);
            if (skillsumonn.SkillTreesumonn == true)
            {
                if (rand < 5) 
                { 
                    var _fuer = Instantiate(go, new Vector2(-1, 0), Quaternion.identity);
                    _fuer.transform.localScale = Vector2.one * 0.5f;
                }
            }
            Destroy(this.gameObject);
        }
    }
}
