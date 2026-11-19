using UnityEngine;

public class ExitGateController : MonoBehaviour
{
    [SerializeField] private GameObject gameCanvas;
    [SerializeField] private GameObject winPanel;

    private bool completed;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (completed || other.GetComponentInParent<PlayerController>() == null)
            return;

        completed = true;

        if (gameCanvas != null)
            gameCanvas.SetActive(true);

        if (winPanel != null)
            winPanel.SetActive(true);
    }
}