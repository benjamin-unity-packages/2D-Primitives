using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Primitives2D
{
    private static GameObject Instantiate(GameObject prefab, Vector2 at, Color color)
    {
        GameObject instance = Object.Instantiate(prefab);
        instance.transform.position = at;
        instance.GetComponent<SpriteRenderer>().material.color = color;
        return instance;
    }

    public static GameObject Capsule(Vector2 at, Color color)
    {
        return Instantiate(Resources.Load<GameObject>("Capsule"), at, color);
    }

    public static GameObject Character(Vector2 at, Color color)
    {
        return Instantiate(Resources.Load<GameObject>("Character"), at, color);
    }

    public static GameObject Circle(Vector2 at, Color color)
    {
        return Instantiate(Resources.Load<GameObject>("Circle"), at, color);
    }

    public static GameObject Diamond(Vector2 at, Color color)
    {
        return Instantiate(Resources.Load<GameObject>("Diamond"), at, color);
    }

    public static GameObject HexagonFlatTop(Vector2 at, Color color)
    {
        return Instantiate(Resources.Load<GameObject>("HexagonFlatTop"), at, color);
    }

    public static GameObject HexagonPointTop(Vector2 at, Color color)
    {
        return Instantiate(Resources.Load<GameObject>("HexagonPointTop"), at, color);

    }

    public static GameObject Square(Vector2 at, Color color)
    {
        return Instantiate(Resources.Load<GameObject>("Square"), at, color);
    }

    public static GameObject SquareRounded(Vector2 at, Color color)
    {
        return Instantiate(Resources.Load<GameObject>("SquareRounded"), at, color);
    }
}