namespace Tmpps.Infrastructure.Template
{
    public class Sample
    {
        public string GetHello(string name = "world")
        {
            return $"Hello {name}.";
        }
    }
}