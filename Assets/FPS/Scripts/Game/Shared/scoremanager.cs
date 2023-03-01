using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scoremanager : MonoBehaviour
{
    public int puntuacion;
    public Text score;


    
    
    // Start is called before the first frame update
    void Start()
    {
        
        puntuacion=0;
        score.text= "Score " + puntuacion;

        

        
    }

    // Update is called once per frame
    void Update()
    {
        score.text= "Score " + puntuacion;
    }
}
