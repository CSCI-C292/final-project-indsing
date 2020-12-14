using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    // Start is called before the first frame update
    public float _speed;
    public float _maxVal; 
    
    void Start()
    {
        
    }

    // Update is called once per frame
    

    void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * direction  * Time.deltaTime * _speed);
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -_maxVal, _maxVal);
        transform.position = position;
        
    }

  
}
