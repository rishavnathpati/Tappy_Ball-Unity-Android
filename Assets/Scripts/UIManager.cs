using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject infoPanel;
    bool btnPressed;
    public AudioSource ClickButton;
    // Start is called before the first frame update
    void Start()
    {
        btnPressed = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Level1");
    }

    public void infoButton()
    {
        //infoPanel.SetActive(true);

        if (btnPressed==false)
        {
            ClickButton.Play();
            infoPanel.SetActive(true);
            btnPressed = true;
        }
        else if(btnPressed==true)
        {
            ClickButton.Play();
            infoPanel.SetActive(false);
            btnPressed = false;
        }
               
    }

    public void fbButton()
    {
        ClickButton.Play();
        Application.OpenURL("https://www.facebook.com/rishav.pati.1");

    }

    public void githubButton()
    {
        Application.OpenURL("https://github.com/rishavnathpati");
        ClickButton.Play();

    }

    public void linkedinButton()
    {
        Application.OpenURL("https://www.linkedin.com/in/rishav-nath-p-67223bb9/");
        ClickButton.Play();

    }

    public void gmailButton()
    {
        Application.OpenURL("https://mail.google.com/mail/?view=cm&fs=1&to=patirishavnath@gmail.com&su=Contact_for_apps&body=BODY&bcc=patirishavnath@gmail.com");
        ClickButton.Play();

    }
}
