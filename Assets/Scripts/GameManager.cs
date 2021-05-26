using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool isGameover = false; 
    public Text scoreText; 
    public GameObject gameoverUI; 
    private int score = 0;

    void Awake()
    {
        if (instance == null) 
        { 
            instance = this; 
        } else 
        {
            Debug.LogWarning("두 개 이상의 게임 매니저가 존재합니다!"); 
            Destroy(gameObject); 
        }
    }
}