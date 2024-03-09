using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Personal.Patterns;
using UnityEngine.SceneManagement;

public class PreLoad : Singleton<PreLoad>
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("Load");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
