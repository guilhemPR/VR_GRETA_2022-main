using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Media;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

enum LevelEnum 
{
    LauchLevel, 
    CurrentLevel,
    MaxLevel,
}

public class TargetScript : MonoBehaviour
{
  
  [SerializeField] private Text ScoreText;
  public SoundPlayer ScoreSound; 
  
  private int scoreValue = 0;
  private LevelEnum _currentStatue;
  

  private void Start()
  {
    Level();
  }

  private void OnCollisionEnter(Collision other)
  {
    Debug.Log("ça marche");
    
    if (other.gameObject.CompareTag("TargetCollider"))
    {
      scoreValue++;

      
      
      ScoreText.text =  "00" + scoreValue ; 
      ScoreSound.Play();
      
      ScoreLevel();
      Level();
    }
    
  
    
  }

  private void ScoreLevel()
  {
    if (scoreValue <= 0)
    {
      _currentStatue = LevelEnum.LauchLevel;
    }
    else if (scoreValue < 10)
    {
      _currentStatue = LevelEnum.CurrentLevel;
    }
    else
    {
      _currentStatue = LevelEnum.MaxLevel;
    }
  }

  private void Level()
  {
    switch (_currentStatue)
    {
      case LevelEnum.LauchLevel:
        break;
      case LevelEnum.CurrentLevel:
        break;
      case LevelEnum.MaxLevel:
        
        break;
        
    }
    
  }
  
 
}


