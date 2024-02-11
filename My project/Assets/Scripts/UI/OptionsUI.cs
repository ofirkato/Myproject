using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsUI : MonoBehaviour {

    public static OptionsUI Instance { get; private set; }

    [SerializeField] private Button closeButton;



    private void Awake()
    {
        Instance = this;

        closeButton.onClick.AddListener(() =>
        {
            Hide();
        });
    }


    private void Start()
    {
        KitchenGameManager.Instance.OnGameUnPaused += KitchenGameManager_OnGameUnPaused;
        Hide();
    }


    private void KitchenGameManager_OnGameUnPaused(object sender, System.EventArgs e)
    {
        Hide();
    }


    public void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
