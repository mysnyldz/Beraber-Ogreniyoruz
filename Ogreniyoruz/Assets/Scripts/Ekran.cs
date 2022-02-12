using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ekran : MonoBehaviour
{
    
    [Header("tus takimi")]
    public string input;
    public Text displayText;

    public string ceptel="11111111111";
    public string acilno="111";
    private bool keypadekrani;
    private float butontiklama=0;
    private float cepteltahmin;
    private float acilnotahmin;
    public GameObject telefonUi;
    public GameObject bolumsonu;
    // Start is called before the first frame update
    void Start()
    {
        butontiklama=0;
        cepteltahmin= ceptel.Length;
        acilnotahmin= acilno.Length;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(butontiklama==cepteltahmin||butontiklama==acilnotahmin)
        {
            butontiklama=0;
            input="";
            telefonUi.SetActive(false);
        }
        else
        {
            input = "";
            displayText.text+=input.ToString();
            butontiklama=0;
        }
        
    }
    
    public void DegerGirisi(string DegerGirisi)
    {
        switch(DegerGirisi){
            case "ara":
            displayText.text="Görüşme başladı";
            break;
            case "kapat":
            telefonUi.SetActive(false);
            bolumsonu.SetActive(true);

            break;
            default:
            butontiklama++;
            input+=DegerGirisi;
            displayText.text+=input.ToString();
            break;
            }
    }
}
