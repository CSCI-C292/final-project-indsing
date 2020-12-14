using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grinchRelease : MonoBehaviour
{
    float _xMin;
    float _xMax;
    float _y;
    [SerializeField] GameObject _present;
    [SerializeField] GameObject _explosive;
     

      void Start()
    {
        _xMin = Camera.main.ViewportToWorldPoint(new Vector3(0,0,0)).x;
        _xMax = Camera.main.ViewportToWorldPoint(new Vector3(1,0,0)).x;
        _y = Camera.main.ViewportToWorldPoint(new Vector3(0,0.9f,0)).y;
        InvokeRepeating("gifts", 0, 1f);
        InvokeRepeating("explosives", 0, 1f);
    }

   
    void gifts(){
        //Debug.Log("spawn enemy!");
        float randX = Random.Range(_xMin, _xMax);
        Instantiate(_present, new Vector3(randX, _y, 0), Quaternion.identity);
    }

    void explosives(){
        //Debug.Log("spawn enemy!");
        float rand1X = Random.Range(_xMin, _xMax);
        Instantiate(_explosive, new Vector3(rand1X, _y, 0), Quaternion.identity);
    }



   


    
}
