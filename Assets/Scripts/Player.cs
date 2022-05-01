using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
  public int currentHP = 70;          // 현재 체력
  public const int maxHP = 100;       // 체력 max
  public string name;                 // 이름
  public string guildName;            // 길드 명
  public int currentLevel = 1;        // 현재 레벨
  //public bool isDead = false;         // 살아있는지 여부
  public int state = 0;               // 플레이어의 현재 상태
  
  private void Start() {
    name = "용감한 용사";
    guildName = "[유니티용병단]";

    string fullName = guildName + "Level" + currentLevel.ToString() + " " + name;

    if (state == 0) {         // 아무것도 하고 있지 않는 상태
      
    } else if (state == 1) {  // 이동 중인 상태
      
    } else if (state == 2) {  // 일반 공격 중인 상태
      
    } else if (state == 3) {  // 스킬 시전 중인 상태
      
    } else if (state == 4) {  // 적에게 맞은 상태
      
    } else if (state == 5) {  // 죽은 상태
      
    } else {
      
    }
  }
}