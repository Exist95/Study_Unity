using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    
    void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    void OnEnable()
    {
        Debug.Log("플레이어가 로그인 했습니다.");
    }

    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    void FixedUpdate()
    {
        Debug.Log("이동~");
        //고정된 실행 주기로 cpu 사용이 많다.
        //물리로직
        //1초에 약 50회
    }

    void Update()
    {
        Debug.Log("몬스터 사냥!");
    }
    //게임 로직 업데이트
    //주기적으로 변하는 분할 로직을 넣음
    //환경에 따라서 실행 주기가 떨어질 수 있음\

    void LateUpdate()
    {
        Debug.Log("경험치 획득.");
    }
    //후처리

    void OnDisable()
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }

    void onDestroy()
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }
}
