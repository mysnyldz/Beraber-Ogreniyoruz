using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fistakma : MonoBehaviour
{
    Camera kamera;
    GameObject[] fisinyeri;
    Vector2 ilk_pozisyon;
    public GameObject FistakmaGo;
    public GameObject Fonmakinesikablo;
    public GameObject Fonmakinesifisli;
    public GameObject makineayarlama;
    // Start is called before the first frame update
    void Start()
    {
        kamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        fisinyeri = GameObject.FindGameObjectsWithTag("fisyeri");
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
            foreach (GameObject fisyeri in fisinyeri)
            {
                if (gameObject.name == fisyeri.name)
                {
                    float mesafe = Vector3.Distance(fisyeri.transform.position, transform.position);
                    if (mesafe <= 1)
                    {
                        transform.position = fisyeri.transform.position;
                        Destroy(this);
                        FistakmaGo.SetActive(false);
                        makineayarlama.SetActive(true);
                        Fonmakinesikablo.SetActive(true);
                        Fonmakinesifisli.SetActive(false);
                        Vector3 pos = new Vector3(1.0f * Camera.main.aspect, 1.0f, -10.0f);
                        Camera.main.gameObject.transform.position = pos;
                        Camera.main.orthographicSize = 4.0f;
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
