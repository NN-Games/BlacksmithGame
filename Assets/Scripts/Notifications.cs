using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Notifications : MonoBehaviour
{
    public static event Action OnNotificationPopup = delegate {  };
    public static Notifications Current = null;
    [SerializeField] private TMP_Text notificationText = null;
    
    private void Awake()
    {
        if (!Current)
            Current = this;
        else
            Destroy(gameObject);
        
        notificationText.gameObject.SetActive(false);
    }

    public void Create(string text)
    {
        notificationText.gameObject.SetActive(true);
        notificationText.text = text;
        
        Invoke(nameof(Hide), 2f);
    }

    private void Hide()
    {
        notificationText.gameObject.SetActive(false);
    }
}
