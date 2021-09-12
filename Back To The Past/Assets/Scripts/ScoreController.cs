using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class ScoreController : MonoBehaviour
{

    int scorecounter = 0;
    public TMP_Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Addscore", 0.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void Addscore()
    {
        scorecounter++;
        scoretext.text = scorecounter.ToString();
        Debug.Log(scorecounter);
    }
}
