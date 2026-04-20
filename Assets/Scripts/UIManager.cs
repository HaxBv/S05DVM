using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button Play;
    public Button Spawn;
    public Button Right;
    public Button Left;

    public float time;
    public bool isPlaying = false;


    public TextMeshProUGUI timerText;
    private void Awake()
    {

    }
    void Start()
    {
        Right.gameObject.SetActive(false);
        Left.gameObject.SetActive(false);
        Spawn.gameObject.SetActive(false);
        timerText.gameObject.SetActive(false);
        GameManager.instance.OnStart += () =>
        {
            Play.gameObject.SetActive(false);
            Spawn.gameObject.SetActive(true);
            Right.gameObject.SetActive(true);
            Left.gameObject.SetActive(true);
        };
        GameManager.instance.OnPlay += () =>
        {
            isPlaying = true;
            timerText.gameObject.SetActive(true);
            Spawn.gameObject.SetActive(false);
            Right.gameObject.SetActive(false);
            Left.gameObject.SetActive(false);

        };

    }
    void Update()
    {
        if (isPlaying)
        {

            time += Time.deltaTime;

            int minutes = Mathf.FloorToInt(time / 60);
            int seconds = Mathf.FloorToInt(time % 60);
            int miliseconds = Mathf.FloorToInt((time * 1000) % 1000);

            //timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + miliseconds.ToString("000");

            timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }
    }
}
