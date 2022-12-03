using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class NotifyList
{
    [Header("NotifyList")]
    public string type;
    public Sprite iconSprite;
    public Color notifyColor;
}

public class NotifyManager : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private float time;

    [Header("Components")]
    [SerializeField] private Image informationBar;
    [SerializeField] private Image timeBar;
    [SerializeField] private Image iconLayer;
    [SerializeField] private Text iconTitle;
    [SerializeField] private Text textContent;

    [SerializeField] private NotifyList[] notifyList = new NotifyList[4];

    // Hidden variables
    private float currentTime;
    private bool activeTimer;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        currentTime = time;
        activeTimer = true;
        audioSource.Play();
    }

    void Update()
    {
        if (activeTimer)
        {
            currentTime -= Time.deltaTime;
            timeBar.fillAmount = currentTime / time; 

            if (currentTime < 0) { Destroy(gameObject); }
        }
    }

    private int ListTypeIndex(string type)
    {
        for (int i = 0; i < notifyList.Length; i++)
        {
            if (notifyList[i].type == type) return i;
        }
        Debug.LogWarning("O tipo" + type + "de notificação não existe");
        return -1;
    }

    public void Notify(string type, string title, string text, float timer)
    {
        int index = ListTypeIndex(type);
        if (index == -1) return;

        iconTitle.text = title;
        textContent.text = text;
        time = timer;

        // Notify Type
        iconLayer.sprite = notifyList[index].iconSprite;
        informationBar.color = notifyList[index].notifyColor;
        timeBar.color = notifyList[index].notifyColor;
    }

    public void NotifyTest(string type)
    {
        int index = ListTypeIndex(type);
        if (index == -1) return;

        iconLayer.sprite = notifyList[index].iconSprite;
        iconTitle.text = type;
        textContent.text = type + " notification message.";
        informationBar.color = notifyList[index].notifyColor;
        timeBar.color = notifyList[index].notifyColor;
    }
}
