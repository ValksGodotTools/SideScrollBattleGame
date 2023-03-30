﻿namespace SideScrollGame;

public static class Prefabs
{
    public static PackedScene Skeleton { get; } = LoadPrefab("skeleton");
    public static PackedScene OrangeBall { get; } = LoadPrefab("orange_ball");

    private static PackedScene LoadPrefab(string path) =>
        GD.Load<PackedScene>($"res://Scenes/Prefabs/{path}.tscn");
}
