public interface IVisitor
{
    void Visit(PowerHealth powerHealth);
    void Visit(PowerSpeed powerSpeed);

    void Unvisit(PowerHealth powerHealth);
    void Unvisit(PowerSpeed powerSpeed);
}