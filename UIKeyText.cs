using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIKeyText : MonoBehaviour
{
    [SerializeField] private Bag bag;
    [SerializeField] private Text text;

    private void Start()
    {
        bag.ChangeAmountKey.AddListener(OnShowKeyText);
    }

    private void OnDestroy()
    {
        bag.ChangeAmountKey.RemoveListener(OnShowKeyText);
    }

    private void OnShowKeyText()
    {
        text.text = bag.GetAmountKey().ToString();
    }
}
