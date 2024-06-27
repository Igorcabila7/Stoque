namespace PrincipalStock
{
    public class DtoResposta<T>
    {
        public string? mensagem { get; set; }
        public T data { get; set; }
    }
}
