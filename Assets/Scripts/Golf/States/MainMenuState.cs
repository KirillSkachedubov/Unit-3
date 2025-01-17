using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace Golf
{
    public class MainMenuState : GameState
    {
        public GameState gamePlayState;
        public LevelController levelController;
        public TMP_Text scoreText;

        public void Playgame()
        {
            Exit();
            gamePlayState.Enter();
        }

        protected override void OnDisable()
        {
            base.OnDisable();
            scoreText.text = $"HScore : {levelController.highscore}";
        }
    }
}
