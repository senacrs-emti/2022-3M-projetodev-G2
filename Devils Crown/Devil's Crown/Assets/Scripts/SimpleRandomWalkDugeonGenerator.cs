using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class SimpleRandomWalkDugeonGenerator : MonoBehaviour{

    [SerializeField]
    protected Vector2Int startPosition = Vector2Int.zero;

    [SerializeField]
    private int interations = 10;
    [SerializeField]
    public int walkLength = 10;
    [SerializeField]
    public bool startRandomlyEachInteration = true;

    [SerializeField]
    private TilemapVisualizer tilemapVisualizer;
    
    public void RunProceduralGeneration(){
        HashSet<Vector2Int> floorPositions = RunRandomWalk();
        tilemapVisualizer.Clear();
        tilemapVisualizer.PaintFloorTiles(floorPositions);
    }

    protected HashSet<Vector2Int> RunRandomWalk(){
        var currentPosition = startPosition;
        HashSet<Vector2Int> floorPositions = new HashSet<Vector2Int>();
        for (int i = 0; i < interations; i++){

            var path = ProceduralGenerationAlgorithms.SimpleRandomWalk(currentPosition, walkLength);
            floorPositions.UnionWith(path);
            if (startRandomlyEachInteration)
                currentPosition = floorPositions.ElementAt(Random.Range(0, floorPositions.Count));
        }
        return floorPositions;
    }
}
