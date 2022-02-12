using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telefon : MonoBehaviour
{
    Camera kamera;
    GameObject[] telefonyeri;
    Vector2 ilk_pozisyon;
    public GameObject telefoncevirme; 
    // Start is called before the first frame update
    void Start()
    {
        kamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        telefonyeri = GameObject.FindGameObjectsWithTag("telahize");
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
            foreach (GameObject telahize in telefonyeri)
            {
                if (gameObject.name == telahize.name)
                {
                    float mesafe = Vector3.Distance(telahize.transform.position, transform.position);
                    if (mesafe <= 1)
                    {
                        transform.position = telahize.transform.position;
                        Destroy(this);
                        telefoncevirme.SetActive(true);
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
