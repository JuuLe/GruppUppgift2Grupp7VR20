using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.Playables;

[System.Serializable]
public class ScoreCounter : PlayableAsset
{
    public int Score = 0;
    int NewPoints;

    private void update()
    {
        Score + NewPoints;
        NewPoints = 0;
    }
}
