using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public static UI_Manager Instance;

    GameObject m_DialogUI;

    TextMeshProUGUI m_CharacterName;

    TextMeshProUGUI m_Message;

    Image m_Character;

    string m_FullMessage;

    bool m_IsDialogShown = false;

    float m_CharTimer = 0.0f;
    const float MAX_CHAR_TIME = 0.02f;
    int m_CharIndex = 0;

    bool m_FullMessageShown = false;

    float m_FadeTimer = 0.0f;
    const float MAX_DISPLAY_TIME = 100.0f;

    [SerializeField]
    AudioClip m_DialogSound;

    AudioSource m_AudioSource;

    Animator m_Animator;

    private void Awake()
    {
        Instance = this;
        m_DialogUI = transform.Find("dialogue").gameObject;
        m_Message = m_DialogUI.transform.Find("text").GetComponent<TextMeshProUGUI>();
        m_CharacterName = m_DialogUI.transform.Find("name").GetComponent<TextMeshProUGUI>();
        m_Character = m_DialogUI.transform.Find("character").GetComponent<Image>();
        m_Animator = m_DialogUI.transform.Find("character").GetComponent<Animator>();
        m_AudioSource = GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    //Update is called once per frame
    void Update()
    {
        if (m_IsDialogShown && !m_FullMessageShown)
        {
            if (m_CharTimer > MAX_CHAR_TIME)
            {
                ShowNextLetter();
                m_CharTimer = 0;
            }
            else
            {
                m_CharTimer += Time.deltaTime;
            }
        }
        else if (m_FullMessageShown)
        {
            if (m_FadeTimer > MAX_DISPLAY_TIME)
            {
                CloseDialog();
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

        //m_CharacterName.text = "";
        m_Message.text = "";
    }

    public void ShowDialog(string name, string message)
    {
        if (m_IsDialogShown)
        {
            Reset();
            ShowNextDialog(message);
            return;
        }

        m_DialogUI.SetActive(true);

        //m_Character.sprite = Resources.Load("Image/" + name, typeof(Sprite)) as Sprite;
        m_Animator.SetTrigger(name);

        m_CharacterName.text = name + ":";

        m_FullMessage = message;
        print(m_FullMessage.Length);

        m_IsDialogShown = true;

        //if(m_dialogsound != null) m_audiosource.playoneshot(m_dialogsound);
    }

    void ShowNextDialog(string message)
    {
        m_IsDialogShown = true;
        m_FullMessage = message;
    }

    public void CloseDialog()
    {
        Reset();
        m_DialogUI.SetActive(false);
        m_IsDialogShown = false;
    }

    void ShowNextLetter()
    {
        m_CharIndex++;
        if (m_CharIndex <= m_FullMessage.Length)
        {
            m_Message.text = m_FullMessage.Substring(0, m_CharIndex);
            if (m_DialogSound != null) m_AudioSource.PlayOneShot(m_DialogSound);
        }
        else
        {
            m_CharIndex = 0;
            m_FullMessageShown = true;
        }
    }
}
