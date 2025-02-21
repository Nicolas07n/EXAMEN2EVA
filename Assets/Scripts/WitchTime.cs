using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchTime : MonoBehaviour
{
    


    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(1)) 
        {
            StartCoroutine(ActivateWitchTime());
        }
       
    }
    IEnumerator ActivateWitchTime()
    {

        Time.timeScale = 0.25f;



        yield return new WaitForSeconds(1.0f);





        Time.timeScale = 1f;



    }    }
