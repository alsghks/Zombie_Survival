using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable/GunData", fileName = "Gun Data")]
public class GunData : MonoBehaviour
{
    public AudioClip shotClip; // 발사 소리
    public AudioClip reloadClip; // 재장전 소리

    public float damage = 25; //공격력

    public int startAmmoRemain = 100; //처음에 주어질 전체 탄알
    public int magCapacity = 25; //탄창 용량

    public float timeBetFire = 012f; //탄알 발사 간격
    public float reloadTime = 1.8f; //재장전 소요 시간
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
