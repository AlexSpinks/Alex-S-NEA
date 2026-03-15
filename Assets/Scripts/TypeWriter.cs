using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class TypewriterMessage
{
    private float timer = 0;
    private int charIndex = 0;
    private const float TimePerChar = 0.05f;

    [SerializeField] public string currentMsg = null;
    private string displayMsg = null;

    private Action onActionCallback = null;

    public TypewriterMessage(string msg, Action callback = null)
    {
        onActionCallback = callback;
        currentMsg = msg;
    }

    public void Callback()
    {
        onActionCallback?.Invoke();
    }

    public string GetFullMsgAndCallback()
    {
        onActionCallback?.Invoke();
        return currentMsg;
    }

    public string GetFullMsg()
    {
        return currentMsg;
    }

    public string GetMsg()
    {
        return displayMsg;
    }

    public void Update()
    {
        if (string.IsNullOrEmpty(currentMsg))
            return;

        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer += TimePerChar;
            charIndex++;

            displayMsg = currentMsg.Substring(0, charIndex);
            displayMsg += "<color=#00000000>" + currentMsg.Substring(charIndex) + "</color>";

            if (charIndex >= currentMsg.Length)
            {
                Callback();
                currentMsg = null;
            }
        }
    }

    public bool IsActive()
    {
        return !string.IsNullOrEmpty(currentMsg) && charIndex < currentMsg.Length;
    }
}

public class TypeWriter : MonoBehaviour
{
    public Text textComponent;

    private static TypeWriter instance;
    private List<TypewriterMessage> messages = new List<TypewriterMessage>();
    private TypewriterMessage currentMsg = null;
    private int msgIndex = 0;

    public static void Add(string msg, Action callback = null)
    {
        TypewriterMessage typeMsg = new TypewriterMessage(msg, callback);
        instance.messages.Add(typeMsg);
    }

    public static void Activate()
    {
        instance.currentMsg = instance.messages[0];
    }

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        if (messages.Count > 0 && currentMsg != null)
        {
            currentMsg.Update();
            textComponent.text = currentMsg.GetMsg();
        }
    }

    public void WriteNextMessageInQueue()
    {
        if (currentMsg != null && currentMsg.IsActive())
        {
            textComponent.text = currentMsg.GetFullMsgAndCallback();
            currentMsg = null;
            return;
        }

        msgIndex++;

        if (msgIndex >= messages.Count)
        {
            currentMsg = null;
            textComponent.text = "";
            return;
        }

        currentMsg = messages[msgIndex];
    }
}
