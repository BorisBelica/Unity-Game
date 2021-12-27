using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // References
    public string firstLevel;
    public GameObject optionsScreen;


    public void SpoznajPiesen() 
    {
        // odkaz na scenu ktorá sa ma nacitat po spusteni funkcii
        SceneManager.LoadScene("Spoznaj Piesen");
        Debug.Log("Spúšaťm hru Spoznaj pieseň");
    }

    public void ZapisPiesen()
    {
        // odkaz na scenu ktorá sa ma nacitat po spusteni funkcii
        // SceneManager.LoadScene("SampleScene");
        Debug.Log("Spúšaťm hru Zapíš pieseň");
    }

    public void NajdiChybu()
    {
        // odkaz na scenu ktorá sa ma nacitat po spusteni funkcii
        // SceneManager.LoadScene("SampleScene");
        Debug.Log("Spúšaťm hru Nájdi chybu");
    }

    public void OtvorNastavenia()
    {
         optionsScreen.SetActive(true);  
    }

    public void ZatvorNastavenia()
    {
        optionsScreen.SetActive(false);  
    }

    public void VypnutHru()
    {
        Application.Quit();
        Debug.Log("Vypínam hru!");
        // quit nefunguje v editore, až pri builde hry
    }


}
