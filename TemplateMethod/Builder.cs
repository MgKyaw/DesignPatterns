namespace TemplateMethod;

abstract class Builder
{
    public void Build()
    {   
        Test();
        Lint();
        Assemble();
        Deploy();
    }   

    abstract public void Test();
    abstract public void Lint();
    abstract public void Assemble();
    abstract public void Deploy();
}