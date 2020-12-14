using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//ToonExplosion v1.0 is not my file it came with the explosive asset that i am using here as the game object from unity assets

public class GameState : MonoBehaviour
{
    // Start is called before the first frame update
    public static int _score = 0;
   
    bool _isGameover = false;



    [SerializeField] GameObject _scoreText;
    [SerializeField] GameObject _gameOverText;
    [SerializeField] GameObject _winnerText;
    [SerializeField] GameObject _explosive;
    [SerializeField] GameObject _enemyExplosives;
    

    public static GameState Instance;

    void Awake() {
        Instance = this;
        
    } 

    void Update(){
        if (Input.GetButtonDown("Submit") && _isGameover) {
            //_gameOverText.SetActive(false);
            //Time.timeScale = 1;
            _score =0;
            items._speed = 5f;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void IncreaseScore(int amount) {
        _score += amount;
        _scoreText.GetComponent<Text>().text = "Score: " + _score;
        
 
    }

    public void InititateGameOver(){
        _isGameover = true;
        _gameOverText.SetActive(true);
        _explosive.SetActive(true);
        //Debug.Log("B");
        //Time.timeScale = 0;
        
    }
     public void Winner(){
        _isGameover = true;
        _winnerText.SetActive(true);
        _enemyExplosives.SetActive(true);
        //Time.timeScale = 0;
        
    }

    

}
