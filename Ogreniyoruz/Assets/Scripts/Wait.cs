using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Wait : MonoBehaviour
{
    public float Wait_time=5f;
    void Start()
    {
        StartCoroutine(bekle());
    }
    IEnumerator bekle() 
    {
        yield return new WaitForSeconds(Wait_time);
        SceneManager.LoadScene(1);
    }
}
