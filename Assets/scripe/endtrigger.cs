using UnityEngine;

public class endtrigger : MonoBehaviour
{
    public GameManager1 GameManager;
    private void OnTriggerEnter( )
    {
        GameManager.Completelevel();
    }
}
