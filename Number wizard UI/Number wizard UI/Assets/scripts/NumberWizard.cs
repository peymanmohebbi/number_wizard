using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] Text guesstxt;

    
    int guess;


	// Use this for initialization
	void Start () {

        StartGame();
	}

    void StartGame()
    {
        Nextguess();
        
    }

    void Nextguess()
    {
        guess = Random.Range(min, max);
        guesstxt.text = guess.ToString();
    }

    public void OnPressHigher()
    {
        min = guess+1;
        Nextguess();
    }

    public void OnPressLower()
    {
        max = guess;
        Nextguess();
    }

}
