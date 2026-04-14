using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button Play;
    public Button Spawn;
    public Button Right;
    public Button Left;
    private void Awake()
    {

    }
    void Start()
    {
        Right.gameObject.SetActive(false);
        Left.gameObject.SetActive(false);
        Spawn.gameObject.SetActive(false);

        GameManager.instance.OnStart += () =>
        {
            Play.gameObject.SetActive(false);
            Spawn.gameObject.SetActive(true);
            Right.gameObject.SetActive(true);
            Left.gameObject.SetActive(true);
        };
        GameManager.instance.OnPlay += () =>
        {
            Spawn.gameObject.SetActive(false);
            Right.gameObject.SetActive(false);
            Left.gameObject.SetActive(false);

        }

    }

    void Update()
    {
        
    }
}
