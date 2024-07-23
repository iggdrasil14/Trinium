using System;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class Saves
{
    public int health;
    public int score;
    
    public static void Save(Saves save)
    {
        string json = JsonUtility.ToJson(save);
        Debug.Log(json);
        PlayerPrefs.SetString("player", json);
    }

    public static Saves Load()
    {
        string json = PlayerPrefs.GetString("player");
        Saves save = JsonUtility.FromJson<Saves>(json);
        return save;
    }
}
