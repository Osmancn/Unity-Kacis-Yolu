using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuAyar : MonoBehaviour {

	// Use this for initialization
	public void Yenile()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
    public void x5()
    {
        
        Application.LoadLevel("5x5");
    }
    public void x6()
    {
        Application.LoadLevel("6x6");
    }
    public void x7()
    {
        Application.LoadLevel("7x7");
    }
    public void x8()
    {
        Application.LoadLevel("8x8");
    }
    public void x9()
    {
        Application.LoadLevel("9x9");
    }
    public void Cik()
    {
        Application.Quit();
    }
    public void AnaMenu()
    {
        Application.LoadLevel("AnaMenu");
    }

}
