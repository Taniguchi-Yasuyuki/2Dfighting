using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Hadouken�i�e�j�̃v���n�u���Ăяo��
    public GameObject HadoukenPrefab;

    // Update is called once per frame
    void Update()
    {
        //V�������ꂽ��Hadouken�i�e�j�̃v���n�u���o������
        if (Input.GetKeyDown(KeyCode.V))
        {
            Instantiate(HadoukenPrefab, transform.position, Quaternion.identity);
        }
    }
}
