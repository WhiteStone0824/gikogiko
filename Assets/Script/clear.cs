using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class clear : MonoBehaviour
{
    public void Clear()
    {
        if (skillpoint.SP > 99)
        {
            SceneManager.LoadScene("title");
            skillpoint.SP = 0;
        }
    }
}
