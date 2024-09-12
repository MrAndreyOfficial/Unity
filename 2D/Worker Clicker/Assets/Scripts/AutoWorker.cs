using System;
using System.Collections;
using UnityEngine;

namespace Worker.Auto
{
    public struct AutoWorker
    {
        private static uint s_count;

        public static uint Count => s_count;

        public static IEnumerator IncreaseScore()
        {
            while (true)
            {
                yield return null;

                if (s_count > 0)
                {
                    yield return new WaitForSeconds(1);

                    Bootstrap.GameData.ScoreData.Increase(s_count);
                    Bootstrap.ScoreText.UpdateDisplay();
                }
            }
        }

        public static void IncreaseBy(uint count = 1)
        {
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count), "Count must not be less than 1");

            s_count += count;
        }
    }
}
