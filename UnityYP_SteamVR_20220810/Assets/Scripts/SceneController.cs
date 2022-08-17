
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem;

namespace Ben
{
    public class SceneController : MonoBehaviour
    {
        private UIElement uiReplay;
        private UIElement uiQuit;
        private string ReplayScene="籃球場";

        private void Awake()
        {
            uiReplay = GameObject.Find("重新遊戲").GetComponent<UIElement>();
            uiQuit = GameObject.Find("離開遊戲").GetComponent<UIElement>();

            uiReplay.onHandClick.AddListener((A) => SceneManager.LoadScene(ReplayScene));
            uiQuit.onHandClick.AddListener((A) => Application.Quit());
        }
    }
}

