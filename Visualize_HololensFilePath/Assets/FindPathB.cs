using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Dummiesman;
using System.IO;



public class FindPathB : MonoBehaviour
{
    string path;
    GameObject obj;
    Transform posi;
    public GameObject c, p;
    void loading(string path)
    {
        var lodedobj = new OBJLoader().Load(path);          //경로에서 파일 로드
        obj = GameObject.Find("Object2");
        posi = obj.GetComponent<Transform>();
        posi.position = new Vector3(-3.25f, -4.2f, -9.5f);  //눈앞에 보이게 transform 조정
        posi.localScale = new Vector3(0.01f, 0.01f, 0.01f);
    }

    void Start()
    {
        string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        path = Path.Combine(FilePath, "Object2.obj");

        if (File.Exists(path))                                  //파일이 경로에 있다면
        {
            loading(path);                                                  //경로에서 파일로드
            Instantiate(c, new Vector3(0.1f, 0, 1), Quaternion.identity);   //red capsule 생성
        }
        else if (!File.Exists(path))                                        //파일이 없다면
        {
            Instantiate(p, new Vector3(-0.1f, 0, 1), Quaternion.identity);//earth model 생성
        }
        Debug.Log(FilePath);
        Debug.Log(path);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
