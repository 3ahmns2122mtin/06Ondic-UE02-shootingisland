using UnityEngine;

public class BadTarget : MonoBehaviour
{
    [SerializeField] private int secToDestroy;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        secToDestroy = 1;
        Destroy(gameObject, secToDestroy);
    }

    private void OnMouseDown()
    {
        gameManager.DecrementScore();
        Destroy(gameObject);
    }

}