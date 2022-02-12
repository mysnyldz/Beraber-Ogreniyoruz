using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject giris;
    public GameObject SecimEkrani;
    public void play()
    {
        giris.SetActive(false);
        SecimEkrani.SetActive(true);    
    }
    public void Geri()
    {
        giris.SetActive(true);
        SecimEkrani.SetActive(false);
    }
    public void Cikis()
    {
        Application.Quit();
    }
    public void Fonmakinebolum()
    {
        SceneManager.LoadScene(2);
    }
    public void telefonBolum()
    {
        SceneManager.LoadScene(3);
    }
    public void CalarSaatbutonu()
    {
        SceneManager.LoadScene(4);
    }
    private void Start() 
    {
        giris.SetActive(true);
        SecimEkrani.SetActive(false);
    }


}
