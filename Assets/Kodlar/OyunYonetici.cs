using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OyunYonetici : MonoBehaviour {

    public Canvas canvas;
    public Button button;
    Button a;
    public int puan;
    public Text oyunBitti;
    public Text skor;
    public int size;


	void Start () {
        puan = 0;
        int x=0, y = 550;
        if (size == 9) x = 200;
        if (size == 8) x = 225;
        if (size == 7) x = 250;
        if (size == 6) x = 275;
        if (size == 5) x = 300;
        for (int i = 1; i <= size; i++)
        {
            y = 550;
            for (int j = 1; j <= size; j ++ )
            {                    
                a = Instantiate(button, new Vector3(x, y, 0), Quaternion.identity);

                a.transform.gameObject.tag = "" + i + "" + j;
                a.transform.SetParent(canvas.transform);
                y -= 50;
            }
            x += 50;
        }		
	}
	
	// Update is called once per frame
	void Update () {
        skor.text = "Skor : " + puan;
	}

    
}
