using System;
using UnityEngine;

public class Actions : MonoBehaviour
{
    public static Actions Instance { get; private set; }

    public Action OnHitEnd { get; set; }
    public Action OnHitMiddle { get; set; }

    private void Awake()
    {
        Instance = this;
    }
}
