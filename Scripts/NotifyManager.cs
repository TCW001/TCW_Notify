using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.UI;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class NotifyManager : MonoBehaviour
{
    [Header("Settings")]
    public float time;

    [Header("Components")]
    public Image informationBar;
    public Image timeBar;
    public Image icon;
    public Text iconTitle;
    public Text textContent;

    [Header("Icons")]
    public Sprite information;
    public Sprite success;
    public Sprite warning;
    public Sprite error;

    // Hidden variables
    private float currentTime;
    private bool activeTimer;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        currentTime = time;
        activeTimer = true;

        audioSource.Play(); // Audio
    }

    void Update()
    {
        // Activating the countdown
        if (activeTimer)
        {
            currentTime -= Time.deltaTime;
            timeBar.fillAmount = currentTime / time;

            if (currentTime < 0)
            {
                Destroy(gameObject);
            }
        }
    }

    // Public function to Instantiate Notify with the appropriate texts and icons
    // Called in other scripts where you want to use it
    public void Notify(string type, string title, string text, float timer)
    {
        time = timer;
        iconTitle.text = title;
        textContent.text = text;

        // Notify Type
        switch (type)
        {
            case "Information":
                icon.sprite = information;
                informationBar.color = new Color32(112, 162, 235, 255);
                timeBar.color = new Color32(112, 162, 235, 255);
                break;

            case "Success":
                icon.sprite = success;
                informationBar.color = new Color32(104, 195, 123, 255);
                timeBar.color = new Color32(104, 195, 123, 255);
                break;

            case "Warning":
                icon.sprite = warning;
                informationBar.color = new Color32(226, 214, 78, 255);
                timeBar.color = new Color32(226, 214, 78, 255);
                break;

            case "Error":
                icon.sprite = error;
                informationBar.color = new Color32(222, 71, 71, 255);
                timeBar.color = new Color32(222, 71, 71, 255);
                break;
        }
    }

    #region Default Notifications
    //Public functions for using standard Notify types
    // Called in some script for example a Terminal

    public void NotifyInformation()
    {
        icon.sprite = information;
        iconTitle.text = "Information";
        textContent.text = "Information notification message";
        informationBar.color = new Color32(112, 162, 235, 255);
        timeBar.color = new Color32(112, 162, 235, 255);
    }

    public void NotifySuccess()
    {
        icon.sprite = success;
        iconTitle.text = "Success";
        textContent.text = "Success notification message";
        informationBar.color = new Color32(104, 195, 123, 255);
        timeBar.color = new Color32(104, 195, 123, 255);
    }

    public void NotifyWarning()
    {
        icon.sprite = warning;
        iconTitle.text = "Warning";
        textContent.text = "Warning notification message";
        informationBar.color = new Color32(226, 214, 78, 255);
        timeBar.color = new Color32(226, 214, 78, 255);
    }

    public void NotifyError()
    {
        icon.sprite = error;
        iconTitle.text = "Error";
        textContent.text = "Error notification message";
        informationBar.color = new Color32(222, 71, 71, 255);
        timeBar.color = new Color32(222, 71, 71, 255);
    }

    #endregion
}
