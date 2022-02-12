using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ayar : MonoBehaviour
{
    public GameObject lamba1,lamba2,lamba3,lamba4,lamba5,lamba6;
    public void hiz1()
    {
        lamba1.SetActive(false);
        lamba2.SetActive(true);
        lamba3.SetActive(true);    
    }
    public void hiz2()
    {
        lamba1.SetActive(true);
        lamba2.SetActive(false);
        lamba3.SetActive(true);    
    }
    public void hiz3()
    {
        lamba1.SetActive(true);
        lamba2.SetActive(true);
        lamba3.SetActive(false);    
    }

    public void sicaklik1()
    {
        lamba4.SetActive(false);
        lamba5.SetActive(true);
        lamba6.SetActive(true);
        
    }
    public void sicaklik2()
    {
        lamba4.SetActive(true);
        lamba5.SetActive(false);
        lamba6.SetActive(true);
        
    }
    public void sicaklik3()
    {
        lamba4.SetActive(true);
        lamba5.SetActive(true);
        lamba6.SetActive(false);
    }
    public void onay()
    {
        gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
