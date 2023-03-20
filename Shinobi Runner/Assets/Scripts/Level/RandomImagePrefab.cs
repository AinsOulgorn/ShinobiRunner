using System.Collections.Generic;
using UnityEngine;

public class RandomImagePrefab : MonoBehaviour
{
    public Sprite[] sprites; // Массив спрайтов, которые будут использоваться для случайного выбора.

    void Start()
    {
        int randomIndex = Random.Range(0, sprites.Length); // Выбираем случайный индекс из массива спрайтов.
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>(); // Получаем компонент SpriteRenderer для нашего префаба.
        spriteRenderer.sprite = sprites[randomIndex]; // Присваиваем случайный спрайт.
    }
}
