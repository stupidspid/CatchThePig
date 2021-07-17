using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GlobalConstants
{
    #region BOMB
    public static readonly int BOMB_DEEFAULT_STATE = 1;
    public static readonly int BOMB_PLACED_STATE = 3;
    public static readonly float BOMB_ATTACK_STATE = 0.1f;
    public static readonly int BOMB_DAMAGE_RADIUS = 100;
    #endregion

    #region ENEMY
    public static readonly int ENEMY_WALKING_RANGE = 50;
    public static readonly int ENEMY_WALKING_DELAY = 3;
    #endregion

    #region PLAYER
    public static readonly int PLAYER_MOVE_STEP = 3;
    public static readonly float JOYSTICK_MOVE_FACTOR = 0.5f;
    public static readonly int SIDE_LIMIT = 600;
    public static readonly int UP_DOWN_LIMIT = 350;
    #endregion
}
