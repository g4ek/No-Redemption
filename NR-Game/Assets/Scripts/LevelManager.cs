using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public GameObject playerPrefab;

    public Transform respawnPoint;

    public void Awake() {
        instance = this;
    }

    public void Respawn() {
        Instantiate(playerPrefab, respawnPoint.position, Quaternion.identity);
    }
}
