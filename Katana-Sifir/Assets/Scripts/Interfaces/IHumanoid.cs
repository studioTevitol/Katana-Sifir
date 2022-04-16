public interface IHumanoid
{
    int CurrentHealth { get; }
    void Move(Vector3 direction);
    void ApplyDamage(int damage);
}
