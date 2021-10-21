using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] public int secToDestroy;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        //secToDestroy = 2;
        //Destroy(gameObject, secToDestroy);
    }

    private void OnMouseDown()
    {
        gameManager.IncrementScore();
        Destroy(gameObject);
    }

}
