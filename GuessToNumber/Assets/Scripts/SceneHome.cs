using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class SceneHome : MonoBehaviour
    {
        public void ButtonOnClickNewGame()
        {
            Root.audio.Play(AudioType.Click);

        }
        public void ButtonOnClickJoinGame()
        {
            Root.audio.Play(AudioType.Click);
        }
    }
}
