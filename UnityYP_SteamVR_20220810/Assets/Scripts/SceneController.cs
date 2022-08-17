
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem;

namespace Ben
{
    public class SceneController : MonoBehaviour
    {
        private UIElement uiReplay;
        private UIElement uiQuit;
        private string ReplayScene="�x�y��";

        private void Awake()
        {
            uiReplay = GameObject.Find("���s�C��").GetComponent<UIElement>();
            uiQuit = GameObject.Find("���}�C��").GetComponent<UIElement>();

            uiReplay.onHandClick.AddListener((A) => SceneManager.LoadScene(ReplayScene));
            uiQuit.onHandClick.AddListener((A) => Application.Quit());
        }
    }
}

