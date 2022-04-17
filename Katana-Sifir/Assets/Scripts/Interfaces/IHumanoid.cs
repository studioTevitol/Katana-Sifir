public interface IHumanoid
{
    int CurrentHealth { get; }
    int MaxHealth { get; }
    void Move(int x, int y);
    void Jump();
    void Attack(IHumanoid target);
    void GetDamage(int damage);
    void Die();
}