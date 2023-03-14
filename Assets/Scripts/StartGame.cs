using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour {
    public void Play() {
        SceneManager.LoadScene(1);
    }
    
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) 
            Application.Quit(); 
    }
    
    public void Quit() {
        Application.Quit();
    }

    public void SoundControl() {
        Text text = GameObject.Find("SoundControl").GetComponent<Text>();
        if (AudioListener.volume > 0) {
            AudioListener.volume = 0;
            text.text = "Sound: Off";
        }
        else {
            AudioListener.volume = 1;
            text.text = "Sound: On";
        }
    }
}