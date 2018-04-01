using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonKontrol : MonoBehaviour {

    public bool tiklandi;
    public bool gidilebilir;
    public Button button;
    GameObject oyunYonetici;
    public bool gidecekYerVarmi ;

	void Start () {
        oyunYonetici = GameObject.FindGameObjectWithTag("GameController");
        tiklandi = false;
        gidilebilir = true;
        gidecekYerVarmi = true;             
    }
	
	// Update is called once per frame
	void Update () {
        if(!gidilebilir)
            gameObject.GetComponent<Button>().interactable = false;
        if (gidilebilir)
            gameObject.GetComponent<Button>().interactable = true;
        if(tiklandi)
            gameObject.GetComponent<Button>().interactable = false;
        if (!gidecekYerVarmi)
            oyunYonetici.GetComponent<OyunYonetici>().oyunBitti.text = "Oyun Bitti";
        if(oyunYonetici.GetComponent<OyunYonetici>().puan==oyunYonetici.GetComponent<OyunYonetici>().size * 
            oyunYonetici.GetComponent<OyunYonetici>().size)
                oyunYonetici.GetComponent<OyunYonetici>().oyunBitti.text = "KAZANDIN";

    }
    
    public void ButtonaTiklandi()
    {
        tiklandi = true;
        oyunYonetici.GetComponent<OyunYonetici>().puan +=1;
        gameObject.GetComponentInChildren<Text>().text
            = oyunYonetici.GetComponent<OyunYonetici>().puan.ToString();
        gameObject.GetComponent<Image>().color = Color.red;

        for (int i = 1; i <= oyunYonetici.GetComponent<OyunYonetici>().size; i++)
        {
            for (int j = 1; j <= oyunYonetici.GetComponent<OyunYonetici>().size; j++)
            {
                GameObject.FindGameObjectWithTag("" + i + "" + j).GetComponent<ButtonKontrol>().gidilebilir
                    = false;

            }
        }

        string tag = gameObject.tag;
        int x = (int.Parse(tag)- int.Parse(tag)%10)/10;
        int y = int.Parse(tag)%10;

        gidecekYerVarmi = false;
        
        for (int i = 1; i < 3; i++)
        {
            for (int j = 1; j < 3; j++)
            {
                if (i == j)
                    continue;
                if (x-i>=1 && y-j>=1 && GameObject.FindGameObjectWithTag("" + (x - i) + "" + (y - j)).
                    GetComponent<ButtonKontrol>().tiklandi==false)
                {
                    GameObject.FindGameObjectWithTag("" +(x-i)+ "" +(y-j)).GetComponent<ButtonKontrol>().
                        gidilebilir = true;
                    gidecekYerVarmi = true;
                }
                if (x-i>=1 && y+j<= oyunYonetici.GetComponent<OyunYonetici>().size
                    && GameObject.FindGameObjectWithTag("" + (x - i) + "" + (y + j)).
                    GetComponent<ButtonKontrol>().tiklandi == false)
                {
                    GameObject.FindGameObjectWithTag("" +(x-i)+ "" +(y+j)).GetComponent<ButtonKontrol>().
                        gidilebilir = true;
                    gidecekYerVarmi = true;
                }
                if (x+i<= oyunYonetici.GetComponent<OyunYonetici>().size && y-j>=1 
                    && GameObject.FindGameObjectWithTag("" + (x + i) + "" + (y - j)).
                    GetComponent<ButtonKontrol>().tiklandi == false)
                {
                    GameObject.FindGameObjectWithTag("" +(x+i)+ "" +(y-j)).GetComponent<ButtonKontrol>().
                        gidilebilir = true;
                    gidecekYerVarmi = true;
                }
                if (x+i<= oyunYonetici.GetComponent<OyunYonetici>().size 
                    && y+j<= oyunYonetici.GetComponent<OyunYonetici>().size 
                    && GameObject.FindGameObjectWithTag("" + (x + i) + "" + (y + j)).
                    GetComponent<ButtonKontrol>().tiklandi == false)
                {
                    GameObject.FindGameObjectWithTag("" +(x+i)+ "" +(y+j)).GetComponent<ButtonKontrol>().
                        gidilebilir = true;
                    gidecekYerVarmi = true;
                }
            }
        }       
    }
    
}
