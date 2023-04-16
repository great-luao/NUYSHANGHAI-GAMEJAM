using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public static DialogManager Instance;

    [SerializeField]
    GameObject m_DialogUI;

    [SerializeField]
    TextMeshProUGUI m_CharacterName;

    [SerializeField]
    TextMeshProUGUI m_Message;

    string m_FullMessage;

    bool m_IsDialogShown = false;

    float m_CharTimer = 0.0f;
    const float MAX_CHAR_TIME = 0.02f;
    int m_CharIndex = 0;

    bool m_FullMessageShown = false;

    float m_FadeTimer = 0.0f;
    const float MAX_DISPLAY_TIME = 3.0f;

    [SerializeField]
    AudioClip m_DialogSound;

    AudioSource m_AudioSource;

    private void Awake()
    {
        Instance = this;

        m_AudioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(m_IsDialogShown && !m_FullMessageShown)
        {
            if(m_CharTimer > MAX_CHAR_TIME)
            {
                ShowNextLetter();
                m_CharTimer = 0;
            }
            else
            {
                m_CharTimer += Time.deltaTime;
            }
        }
        else if(m_FullMessageShown)
        {
            if (m_FadeTimer > MAX_DISPLAY_TIME)
            {
                m_DialogUI.SetActive(false);
                Reset();
            }
            else
            {
                m_FadeTimer += Time.deltaTime;
            }
        }
    }

    private void Reset()
    {
        m_FullMessage = "";
        m_IsDialogShown = false;

        m_CharTimer = 0.0f;
        
        m_CharIndex = 0;

        m_FullMessageShown = false;

        m_FadeTimer = 0.0f;

        m_CharacterName.text = "";
        m_Message.text = "";
    }

    public void ShowDialog(string name, string message)
    {
        if(m_IsDialogShown)
        {
            return;
        }

        m_DialogUI.SetActive(true);
        m_CharacterName.text = name + ":";

        m_FullMessage = message;

        m_IsDialogShown = true;

        m_AudioSource.PlayOneShot(m_DialogSound);
    }

    void ShowNextLetter()
    {
        m_CharIndex++;
        if (m_CharIndex < m_FullMessage.Length)
        {
            m_Message.text = m_FullMessage.Substring(0, m_CharIndex);
        }
        else
        {
            m_CharIndex = 0;
            m_FullMessageShown = true;
        }
    }
}
