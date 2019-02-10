using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextscene : MonoBehaviour {

	public void Loadnextscece()
    {
        int Currentsceneindx = SceneManager.GetActiveScene().buildIndex;
        if (Currentsceneindx != 2)
            SceneManager.LoadScene(Currentsceneindx + 1);
        else
            SceneManager.LoadScene(Currentsceneindx - 2);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
