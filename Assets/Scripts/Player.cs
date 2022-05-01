using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class Player : MonoBehaviour {

  public enum State {
    Idle = 0, // 아무것도 하지 않는 상태
    Move,     // 이동 중인 상태
    Attack,   // 공격 중인 상태
    Skill,    // 스킬 사용 중인 상태
    Damaged,  // 적에게 공격을 받아 피해를 받은 상태
    Die       // 죽은 상태
  }
  
  public int currentHP = 70;                // 현재 체력
  public const int maxHP = 100;             // 체력 max
  public string name = "용감한 용사";        // 이름
  public string guildName = "[유니티용병단]";// 길드 명
  public int currentLevel = 1;              // 현재 레벨
  //public int state = 0;                   // 플레이어의 현재 상태 (정수형)
  public State currentState = State.Idle;   // 플레이어의 현재 상태 (열거체)
  
  private void Start() {
    string fullName = guildName + "Level" + currentLevel.ToString() + " " + name;

    switch (currentState) {
      case State.Idle:
        Idle();
        break;
      case State.Move:
        Move();
        break;
      case State.Attack:
        Attack();
        break;
      case State.Skill:
        Skill();
        break;
      case State.Damaged:
        Damaged();
        break;
      case State.Die:
        Die();
        break;
      default:
        break;
    }
  }

  private void Idle() {
    Debug.Log("Idle");
  }

  private void Move() {
    Debug.Log("Move");
  }

  private void Attack() {
    Debug.Log("Attack");
  }

  private void Skill() {
    Debug.Log("Skill");
  }

  private void Damaged() {
    Debug.Log("Damaged");
  }

  private void Die() {
    Debug.Log("Die");
  }
}