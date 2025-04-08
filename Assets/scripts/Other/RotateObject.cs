using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public Transform targetObject; // Объект, к которому нужно повернуться
    public SpriteRenderer spriteRenderer; // Рендерер спрайта вашего персонажа

    private void Update()
    {
        if (targetObject != null && spriteRenderer != null)
        {
            // Проверяем, находится ли цель слева или справа от нас
            float directionX = targetObject.position.x - transform.position.x;

            // Устанавливаем масштаб по оси X в зависимости от направления
            spriteRenderer.flipX = directionX < 0;
        }
    }
}
