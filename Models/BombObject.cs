using Silk.NET.SDL;

namespace TheAdventure.Models;

public class BombObject : TemporaryGameObject
{
    public double DamageRadius { get; init; }
    public BombObject(SpriteSheet spriteSheet, double ttl, (int X, int Y) position, double angle = 0.0,
        Point rotationCenter = new(), int damage_radius = 25)
        : base(spriteSheet, ttl, position, angle, rotationCenter)
    {
        DamageRadius = damage_radius;
    }
}