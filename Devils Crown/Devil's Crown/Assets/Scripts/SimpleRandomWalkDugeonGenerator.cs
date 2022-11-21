using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;



public class SimpleRandomWalkDugeonGenerator : AbstractDungeonGenerator
{

    [SerializeField]
    private SimpleRandomWalkSO randomWalkParameters;
    

    protected override void RunProceduralGeneration()
    {
        HashSet<Vector2Int> floorPositions = RunRandomWalk(randomWalkParameters);
        tilemapVisualizer.Clear();
        tilemapVisualizer.PaintFloorTiles(floorPositions);
        WallGenerator.CreateWalls(floorPositions, tilemapVisualizer);
    }

    protected HashSet<Vector2Int> RunRandomWalk(SimpleRandomWalkSO parameters)
    {
        var currentPosition = startPosition;
        HashSet<Vector2Int> floorPositions = new HashSet<Vector2Int>();
        for (int i = 0; i < parameters.interations; i++){

            var path = ProceduralGenerationAlgorithms.SimpleRandomWalk(currentPosition, parameters.walkLength);
            floorPositions.UnionWith(path);
            if (parameters.startRandomlyEachInteration)
                currentPosition = floorPositions.ElementAt(Random.Range(0, floorPositions.Count));
        }
        return floorPositions; 
    }

}
