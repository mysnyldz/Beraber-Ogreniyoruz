using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fonmakine : MonoBehaviour
{
    Camera kamera;
    GameObject[] fonyeri;
    Vector2 ilk_pozisyon;
    public Animator animator;
    public GameObject bolumsonu; 
    // Start is called before the first frame update
    void Start()
    {
        kamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        fonyeri = GameObject.FindGameObjectsWithTag("fonunyeri");
        ilk_pozisyon = transform.position;
    }

     private void OnMouseDrag()
    {
        Vector3 pozisyon = kamera.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            foreach (GameObject fonunyeri in fonyeri)
            {
                if (gameObject.name == fonunyeri.name)
                {
                    float mesafe = Vector3.Distance(fonunyeri.transform.position, transform.position);
                    if (mesafe <= 1)
                    {
                        animator.SetFloat("aktif", mesafe);
                        transform.position = fonunyeri.transform.position;
                        bolumsonu.SetActive(true);
                        Destroy(this);

                    }
                    else
                    {
                        transform.position = ilk_pozisyon;

                    }

                }
            }
        }
    }
}
