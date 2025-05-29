using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPositionSAver : MonoBehaviour
{
    private Vector3 lastPosition;

    private void Start()
    {
        LoadPosition();
    }

    private void Update()
    {
        // Сохранение позиции игрока при переходе на другую сцену
        if (Input.GetKeyDown(KeyCode.F)) // Можно заменить любым событием перехода
        {
            SavePosition();
        }
    }

    private void SavePosition()
    {
        lastPosition = transform.position;
        Debug.Log("Позиция сохранена: " + lastPosition);
    }

    private void LoadPosition()
    {
        if (lastPosition != Vector3.zero)
        {
            transform.position = lastPosition;
            Debug.Log("Позиция восстановлена: " + lastPosition);
        }
    }

    // Альтернативный способ вызова через менеджер сцен
    public static void SaveCurrentPosition(GameObject player)
    {
        PlayerPrefs.SetFloat("LastX", player.transform.position.x);
        PlayerPrefs.SetFloat("LastY", player.transform.position.y);
        PlayerPrefs.SetFloat("LastZ", player.transform.position.z);
    }

    public static void LoadPreviousPosition(GameObject player)
    {
        float x = PlayerPrefs.GetFloat("LastX");
        float y = PlayerPrefs.GetFloat("LastY");
        float z = PlayerPrefs.GetFloat("LastZ");
        player.transform.position = new Vector3(x, y, z);
    }

    public void CheckLoadScene()
    {
        int n = PlayerPrefs.GetInt("scen");
        int b = SceneManager.GetActiveScene().buildIndex;
        
    }
}
