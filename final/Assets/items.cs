using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class items : MonoBehaviour
{
    // Start is called before the first frame update
    public static float _speed = 5f;

    
    
    
    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, Time.deltaTime * _speed, 0);
    }

    void OnTriggerEnter2D(Collider2D collider) {
        Destroy(gameObject);
        if(gameObject.tag == "end"){
            //Debug.Log("a");
            
            Destroy(collider.gameObject); 
            GameState.Instance.InititateGameOver();

           
        }
        else if(collider.gameObject.tag== "Player")
            GameState.Instance.IncreaseScore(10);
            if(GameState._score == 200){
                Destroy(collider.gameObject); 
                GameState.Instance.Winner();
        }
            _speed = _speed + .3f;

            
    }

    

    
}
