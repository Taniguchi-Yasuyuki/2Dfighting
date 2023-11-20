using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Hadouken（弾）のプレハブを呼び出す
    public GameObject HadoukenPrefab;

    // Update is called once per frame
    void Update()
    {
        //Vが押されたらHadouken（弾）のプレハブが出現する
        if (Input.GetKeyDown(KeyCode.V))
        {
            Instantiate(HadoukenPrefab, transform.position, Quaternion.identity);
        }
    }
}
