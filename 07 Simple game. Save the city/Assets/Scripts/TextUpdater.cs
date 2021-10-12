using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdater : MonoBehaviour
{
    [SerializeField] private Text textElement;
    private Slider customizeElement;

    void Start()
    {
        customizeElement = GetComponent<Slider>();
    }

    void Update()
    {
        textElement.text = customizeElement.value.ToString();
    }
}
