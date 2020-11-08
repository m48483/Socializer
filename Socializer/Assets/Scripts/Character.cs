﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    
    public string Gender;
    public string Name;
    InputName ChName;
    GenderChoose genderchoose;
   
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        ChName = GameObject.Find("InputName").GetComponent<InputName>();
        genderchoose= GameObject.Find("Canvas").GetComponent<GenderChoose>();
    }
    
    void Update()
    {
        CharacterGender();
        CharacterName();
    }
    
    public void CharacterName()
    {
        Name = ChName.SendName;
    }
    public void CharacterGender()
    {
        if (genderchoose.GN == 0)
            Gender = "Male";
        else if (genderchoose.GN == 1)
            Gender = "Female";
    }

}
