using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dummiesman;
using System.IO;
using System;


public class FindPathP : MonoBehaviour
{
    string [] f_path = new string[4];

    public GameObject p;
    //public GameObject p, s, d, e;
    public GameObject c;
    GameObject obj;

    Transform posi;


    void loading(string path)
    {
        var lodedobj = new OBJLoader().Load(path);          //경로에서 파일 불러옴
        obj = GameObject.Find("Object2");                   //import files form filepath
        posi = obj.GetComponent<Transform>();
        posi.position = new Vector3(-3.25f, -4.2f, -9.5f);  //눈앞에 보이게 transform 조정
        posi.localScale = new Vector3(0.01f, 0.01f, 0.01f); //Adjust transform inspecter to be visible
    }


    void Start()
    {
        Instantiate(c, new Vector3(0f, 0.25f, 1f), Quaternion.identity);        //Create red capsule to verify that code is active                 

        f_path[0] = Application.persistentDataPath;
        f_path[1] = Application.streamingAssetsPath;
        f_path[2] = Application.dataPath;
        f_path[3] = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

        string[] file_p = new string[4];
        string[] fp = new string[4];

        for (int i = 0; i < 4; i++)
        {
            file_p[i] = Path.Combine(f_path[i], "Object2.obj");
            fp[i] = file_p[i].Replace("\\", "/");
            Debug.Log(fp[i]);
                
            if (File.Exists(fp[i])) //If filepath fp[i] is valid recall function loading
            {
                loading(fp[i]);
                Debug.Log("Valid Path : " + i);
            }
            else if (!File.Exists(fp[i]))
            {
                Instantiate(p, new Vector3(-0.1f, 0f, 0.5f), Quaternion.identity);  //홀로렌즈에서 파일을 찾지 못하면 큐브를 생성하도록 트릭 설치
                Debug.Log("Invalid Path : " + i);                                   //Creat earth model when code can't find the file from hololens storage path
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
