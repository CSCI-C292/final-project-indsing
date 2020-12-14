using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grinch : MonoBehaviour
{
    // Start is called before the first frame update
    int _speed = 5;
    public float _maxVal;
    SpriteRenderer spriteRenderer;
   
    

    
    void Start()
    {
         spriteRenderer = GetComponent<SpriteRenderer>();
    }
  
       

    // Update is called once per frame
    void Update()
    {

        if(GameState._score == 200){
            Destroy(gameObject); 
        }
        //float direction = Input.GetAxis("Horizontal");
        if(transform.position.x <= -6.5){
            spriteRenderer.flipX = false;
            _speed = 5;
            
        }
        if(transform.position.x >= 6.5){
           spriteRenderer.flipX = true;
            _speed = -5;
            
        }

        transform.Translate(_speed * Time.deltaTime, 0, 0);
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, -_maxVal, _maxVal);
        transform.position = position;
        
    }
}
