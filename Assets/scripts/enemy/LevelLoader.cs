using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    void OnEnable()
    {
        SceneManager.sceneUnloaded += OnSceneUnloaded;
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneUnloaded -= OnSceneUnloaded;
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneUnloaded(Scene scene)
    {
        foreach (var enemy in FindObjectsOfType<EnemyController>())
        {
            SceneManagerHelper.SaveEnemyState(enemy.gameObject);
        }
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        foreach (var enemy in FindObjectsOfType<EnemyController>())
        {
            var active = SceneManagerHelper.GetEnemyState(enemy.name, enemy.GetInstanceID());
            enemy.gameObject.SetActive(active);
        }
    }
}
