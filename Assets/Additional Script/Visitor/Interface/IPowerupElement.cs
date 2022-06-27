public interface IPowerupElement
{
    void Accept(IVisitor visitor);
    void Deline(IVisitor visitor);
}