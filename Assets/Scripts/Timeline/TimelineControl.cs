using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimelineControl : MonoBehaviour
{
    [SerializeField] GameObject officeLight;
    [SerializeField] GameObject blackScreen;

    void Start()
    {
        Cursor.visible = false;
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ShutdownElectric()
    {
        officeLight.SetActive(false);
        blackScreen.SetActive(true);
    }
}
