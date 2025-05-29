using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDataStorage : ScriptableObject
{
    private static EnemyDataStorage _instance;
    public static EnemyDataStorage instance { get => _instance ?? (_instance = Resources.Load<EnemyDataStorage>("EnemyData")); }

    [System.Serializable]
    struct EnemyRecord
    {
        public string enemyName;
        public int instanceID;
        public bool isDead;
    }

    List<EnemyRecord> enemies = new List<EnemyRecord>();

    public bool HasDataForEnemy(EnemyController enemy)
    {
        return enemies.Exists(e => e.enemyName == enemy.name && e.instanceID == enemy.GetInstanceID());
    }

    public bool IsEnemyDead(EnemyController enemy)
    {
        EnemyRecord record = enemies.Find(e => e.enemyName == enemy.name && e.instanceID == enemy.GetInstanceID());
        return record.isDead;
    }
}
