
using UnityEngine;
using Valve.VR.InteractionSystem;

public class SpawnBasketball : MonoBehaviour
{
    [SerializeField, Header("훫쾧퉥퇹か")] private GameObject goBasketball;
    private UIElement btnSpawnBasketball;
    private Transform traPlayer;
    private void Awake()
    {
        traPlayer = GameObject.Find("Player").transform;
        btnSpawnBasketball = GameObject.Find("ヶ턵Ν┬훫쾧").GetComponent<UIElement>();
        btnSpawnBasketball.onHandClick.AddListener((x) => Instantiate(goBasketball));
        /*btnSpawnBasketball.onHandClick.AddListener((x) => {
            Vector3 posBall = traPlayer.position + traPlayer.forward * 0.8f + traPlayer.up;
            Instantiate(goBasketball, posBall, Quaternion.identity);
        });*/
    }
}
