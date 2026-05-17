using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Platformer.UI
{
    /// <summary>
    /// Controls the victory/congratulations screen shown when the player completes the level.
    /// Attach this script to a Canvas GameObject in the scene, then assign the panel and
    /// text fields in the Inspector.
    /// </summary>
    public class VictoryUIController : MonoBehaviour
    {
        public static VictoryUIController Instance { get; private set; }

        [Header("Victory Panel")]
        [Tooltip("The root panel GameObject to show/hide (assign your victory UI panel here)")]
        public GameObject victoryPanel;

        [Tooltip("The main congratulations text label")]
        public TMP_Text congratsText;

        [Tooltip("The message shown below the main heading")]
        public TMP_Text subtitleText;

        [Header("Messages")]
        public string congratsMessage = "Congratulations!";
        public string subtitleMessage = "You completed Little Chaser!";

        void Awake()
        {
            Instance = this;
            if (victoryPanel != null)
                victoryPanel.SetActive(false);
        }

        /// <summary>
        /// Called by PlayerEnteredVictoryZone to display the victory screen.
        /// </summary>
        public void ShowVictoryScreen()
        {
            if (victoryPanel == null) return;

            if (congratsText != null)
                congratsText.text = congratsMessage;

            if (subtitleText != null)
                subtitleText.text = subtitleMessage;

            victoryPanel.SetActive(true);
        }

        void OnDestroy()
        {
            if (Instance == this) Instance = null;
        }
    }
}
