using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class priz : MonoBehaviour
{
    Camera kamera;
    Vector2 ilk_pozisyon;
    public GameObject fistakmaGo;
    // Start is called before the first frame update
    void Start()
    {
        kamera = GameObject.Find("Main Camera").GetComponent<Camera>();
        ilk_pozisyon = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider.tag=="priztik") {
                fistakmaGo.SetActive(true);
            }
        }
    
    }
}
