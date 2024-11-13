using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[CreateAssetMenu(menuName = "Tiles/AnimatedTile")]
public class AnimateTiles : TileBase
{
    public Sprite[] spriteAnimationList; //list of sprites in animation sequence
    public float animationSpeed; //time between frames
    public float startTimeOffset = 0f;//offset when the animation starts
    public Tile.ColliderType colliderType = Tile.ColliderType.None; //assign type of collider user wants

    public override void GetTileData(Vector3Int position, ITilemap tilemap, ref TileData tileData)
    {
        if (spriteAnimationList != null && spriteAnimationList.Length > 0) 
        {
            tileData.sprite = spriteAnimationList[0];
            tileData.colliderType = colliderType;          
        }
    }

    public override bool GetTileAnimationData(Vector3Int position, ITilemap tilemap, ref TileAnimationData tileAnimationData)
    {
        if (spriteAnimationList != null && spriteAnimationList.Length > 0)
        {
            tileAnimationData.animatedSprites = spriteAnimationList;
            tileAnimationData.animationSpeed = animationSpeed; 
            tileAnimationData.animationStartTime= startTimeOffset;
            return true;
        }

        return false;
    }
}
