using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WorkingWithNumbersB20 : MonoBehaviour 
{

    public string[] aOldEnglishB20;

    public Text tSheepCount;
    public Text tMarbleCount;
    public Text tTotalSheepCount;

    private int iSheepCount;
    private int iMarbleCount;
    private int iTotalSheepCount;

	void Update () 
    {
        DisplayText();	
	}

    void DisplayText()
    {
        tSheepCount.text = "Sheep Count:" + " " + aOldEnglishB20[iSheepCount];
        tMarbleCount.text = "Marble Count:" + " " + iMarbleCount.ToString("0");
        tTotalSheepCount.text = "Total Sheep Count:" + " " + iTotalSheepCount.ToString("0");
    }

    public void ButtonPressed()
    {
        if (iSheepCount < 20)
        {
            iSheepCount++;
        }
        else
        {
            iMarbleCount++;
            iSheepCount = 0;
        }

        if (iSheepCount != 0)
        {
            iTotalSheepCount++;
        }
    }
}
