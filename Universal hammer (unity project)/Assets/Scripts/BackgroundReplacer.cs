using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class BackgroundReplacer : MonoBehaviour
{
    [SerializeField] private List<Sprite> _sprites;

    private Image _image;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    private void Start()
    {
        var randomImageIndex = Random.Range(0, _sprites.Count);
        _image.sprite = _sprites[randomImageIndex];
    }
}
