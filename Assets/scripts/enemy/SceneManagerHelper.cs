using UnityEngine;
using System.Collections.Generic;

public static class SceneManagerHelper
{
    private static Dictionary<string, bool> enemyStates = new Dictionary<string, bool>();

    public static void SaveEnemyState(GameObject enemy)
    {
        string key = $"{enemy.name}_{enemy.GetInstanceID()}";
        bool state = enemy.activeSelf;
        enemyStates[key] = state;
    }

    public static bool GetEnemyState(string name, int instanceId)
    {
        string key = $"{name}_{instanceId}";
        return enemyStates.ContainsKey(key) ? enemyStates[key] : true;
    }

    public static void ClearAllEnemies()
    {
        enemyStates.Clear();
    }
}
