using System.Collections.Generic;
using UnityEngine;

public class RandomImagePrefab : MonoBehaviour
{
    public Sprite[] sprites; // ������ ��������, ������� ����� �������������� ��� ���������� ������.

    void Start()
    {
        int randomIndex = Random.Range(0, sprites.Length); // �������� ��������� ������ �� ������� ��������.
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>(); // �������� ��������� SpriteRenderer ��� ������ �������.
        spriteRenderer.sprite = sprites[randomIndex]; // ����������� ��������� ������.
    }
}
