using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneEditor : MonoBehaviour
{
    public void GameLoadScene (string level)
    {
        SceneManager.LoadScene (level);
    }

}
