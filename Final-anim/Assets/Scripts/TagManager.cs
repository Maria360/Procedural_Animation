using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTags
{
    public const string MOVEMENT = "Movement";
    public const string RUN = "Run";
    public const string PUNCH_1_TRIGGER = "Punch 1";
    public const string PUNCH_2_TRIGGER = "Punch 2";
    public const string PUNCH_3_TRIGGER = "Punch 3";

    public const string JUMP_TRIGGER = "Jump";
    public const string CROUCH_TRIGGER = "Crouch";
    public const string BREAKER_TRIGGER = "Breaker";

    public const string IDLE_ANIMATION = "Idle";

    public const string HIT_TRIGGER = "Hit";

    public const string KNOCK_DOWN_TRIGGER = "knockDown";

}
public class Axis
{
    public const string HORIZONTAL_AXIS = "Horizontal";
    public const string VERTICAL_AXIS = "Vertical";
}
public class Tags
{
    public const string GROUND_TAG = "Ground";
    public const string PLAYER_TAG = "Player";
    public const string ENEMY_TAG = "Enemy";

    public const string LEFT_ARM_TAG = "LeftArm";
    public const string LEFT_ARM_LEG = "LeftLeg";
    public const string UNTAGGED_TAG = "Untagged";
    public const string MAIN_CAMERA_TAG = "Camera";
    public const string HEALTH_UI = "HealthUI";
}